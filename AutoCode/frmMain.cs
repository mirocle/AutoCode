using System;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using AutoCode.DataAccess;
using AutoCode.Properties;
using AutoCode.Template;
using System.Threading;

namespace AutoCode
{
    public partial class FrmMain : Form
    {

        #region 变量、属性定义

        string _txtConn = string.Empty;
        bool _isConnSuccess;

        #endregion

        #region 窗口初始化

        public FrmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region 本地事件

        #region 窗口相关
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtServer.Text = System.Configuration.ConfigurationManager.AppSettings["server"];
            txtUserName.Text = System.Configuration.ConfigurationManager.AppSettings["user"];
            txtPassword.Text = System.Configuration.ConfigurationManager.AppSettings["pwd"];
        }

        /// <summary>
        /// 窗口关闭
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        #endregion

        #region 数据库连接相关
        /// <summary>
        /// 数据库选择绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDataBase_Enter(object sender, EventArgs e)
        {
            if (!CheckString())
            {
                return;
            }

            string connString = "Database=master;Server=" + txtServer.Text + ";Integrated Security=False;Password=" + txtPassword.Text + ";User ID=" + txtUserName.Text + ";";


            DataTable dt = Access.GetDataBasesByType(connString);


            cmbDataBase.DataSource = dt;
            cmbDataBase.DisplayMember = "name";
            cmbDataBase.ValueMember = "name";
        }

        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (!CheckString())
            {
                return;
            }
            if (Access.CheckDbConnection(_txtConn))
            {
                _isConnSuccess = true;
                MessageBox.Show(Resources.TestConnetSucess);
            }
            else
            {
                _isConnSuccess = false;
                MessageBox.Show(Resources.TestConnetFailure);
            }
        }

        /// <summary>
        /// 数据库选择变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtConn = "Database=" + cmbDataBase.SelectedValue + ";Server=" + txtServer.Text + ";Integrated Security=False;Password=" + txtPassword.Text + ";User ID=" + txtUserName.Text + ";";
        }

        /// <summary>
        /// 数据库地址变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            _isConnSuccess = false;
        }

        /// <summary>
        /// 数据库用户名变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            _isConnSuccess = false;
        }

        /// <summary>
        /// 数据库密码变动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _isConnSuccess = false;
        }

        #endregion

        #region Grid操作相关
        private void tsmiAllSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTables.Items.Count; i++)
            {
                clbTables.SetItemChecked(i, true);
            }
        }

        private void tsmiAllNotSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTables.Items.Count; i++)
            {
                clbTables.SetItemChecked(i, false);
            }
        }

        private void tsmiSelectOther_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < clbTables.Items.Count; i++)
            {
                clbTables.SetItemChecked(i, clbTables.GetItemCheckState(i) != CheckState.Checked);
            }
        }
        #endregion

        #region 模版生成相关

        private void btnGetTable_Click(object sender, EventArgs e)
        {
            BindTables();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!CheckString())
            {
                return;
            }

            //if (string.IsNullOrEmpty(tbNameSpace.Text))
            //{
            //    MessageBox.Show("名称空间必须输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (clbTables.CheckedItems.Count <= 0)
            {
                MessageBox.Show(Resources.SelectTable, Resources.Alert, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (var i = 0; i < clbTables.CheckedItems.Count; i++)
            {
                var tableName = string.Empty;
                var dtColunms = Access.GetTableColunms(clbTables.CheckedItems[i].ToString(), _txtConn);
                var originalTableName = clbTables.CheckedItems[i].ToString();
                if (originalTableName.IndexOf('_') > 0)
                {
                    string[] arrayTableName = originalTableName.Split('_');
                    tableName = arrayTableName.Aggregate(tableName, (current, tName) => current + Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tName.ToLower()));
                    //tableName = OriginalTableName.Substring(0, 1).ToUpper() + OriginalTableName.Substring(1, OriginalTableName.IndexOf("_")).ToLower()
                    //           + OriginalTableName.Substring(OriginalTableName.IndexOf("_") + 1, 1) + OriginalTableName.Substring(OriginalTableName.IndexOf("_") + 2).ToLower();
                }
                else
                {
                    tableName = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(originalTableName.ToLower()); 
                }
                var schema = new SchemaTemplate
                {
                    NameSpace = tbNameSpace.Text,
                    DtColunms = dtColunms,
                    TableName = tableName,
                    OriginalTableName = originalTableName
                };
                CreateSchemaFile(schema);

                var entity = new EntityTemplate
                {
                    NameSpace = tbNameSpace.Text,
                    DtColunms = dtColunms,
                    TableName = tableName
                };
                CreateEntityFile(entity);

                var dataaccess = new DataAccessTemplate
                {
                    NameSpace = tbNameSpace.Text,
                    DtColunms = dtColunms,
                    TableName = tableName
                };
                CreateDataAccessFile(dataaccess);

                var business = new BusinessTemplate
                {
                    NameSpace = tbNameSpace.Text,
                    DtColunms = dtColunms,
                    TableName = tableName
                };
                CreateBusinessFile(business);

                var model = new ModelTemplate
                {
                    NameSpace = tbNameSpace.Text,
                    DtColunms = dtColunms,
                    TableName = tableName
                };
                CreateModelFile(model);
            }

            MessageBox.Show(Resources.OutPutSuccess);
        }

        #endregion

        #endregion

        #region 本地方法

        #region 绑定Table表
        private void BindTables()
        {
            if (!_isConnSuccess)
            {
                if (Access.CheckDbConnection(_txtConn))
                {
                    BindTable();
                }
            }
            else
            {
                BindTable();
            }
        }

        private void BindTable()
        {
            clbTables.Items.Clear();
            DataTable dt = Access.GetAllTables(_txtConn);
            foreach (DataRow row in dt.Rows)
            {
                clbTables.Items.Add(row["name"]);
            }
        }
        #endregion

        #region 文件输出
        private void CreateSchemaFile(SchemaTemplate schema)
        {
            outPutFile("Common\\Schema", schema.ClassName + ".cs", schema.TransformText());
        }

        private void CreateEntityFile(EntityTemplate entity)
        {
            outPutFile("Common\\Entity", entity.EntityClassName + ".cs", entity.TransformText());
        }

        private void CreateDataAccessFile(DataAccessTemplate dataaccess)
        {
            outPutFile("DataAccess", dataaccess.AccessClassName + ".cs", dataaccess.TransformText());
        }

        private void CreateBusinessFile(BusinessTemplate business)
        {
            outPutFile("Business", business.BusinessClassName + ".cs", business.TransformText());
        }

        private void CreateModelFile(ModelTemplate model)
        {
            outPutFile("Common\\Models", model.ModelClassName + ".cs", model.TransformText());
        }

        

        private void outPutFile(string path, string filename, string fileContent)
        {
            string directoryPath = Path.Combine(ConfigurationManager.AppSettings["SavePath"], path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(directoryPath);
            }
            string filePath = Path.Combine(directoryPath, filename);
            var fs = new FileStream(filePath, FileMode.OpenOrCreate);
            var sw = new StreamWriter(fs);
            sw.Write(fileContent);
            sw.Close();
        }
        #endregion

        #endregion

        #region 数据校验
        /// <summary>
        /// 检查数据完整性
        /// </summary>
        /// <returns></returns>
        private bool CheckString()
        {
            if (string.IsNullOrEmpty(txtServer.Text))
            {
                MessageBox.Show(Resources.InputServerAddr);
                return false;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show(Resources.InputUserName);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(Resources.InputPwd);
                return false;
            }
            return true;
        }

        #endregion
    }
}
