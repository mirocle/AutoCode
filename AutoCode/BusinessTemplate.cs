﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 10.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AutoCode.Template
{
    using System.Data;
    using System;
    
    
    #line 1 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class BusinessTemplate : BusinessTemplateBase
    {
        public virtual string TransformText()
        {
            this.Write("\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing System.Data;\r\nusing Cor" +
                    "e.DataAccess;\r\n");
            
            #line 9 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"

	if(NameSpace =="")
	{

            
            #line default
            #line hidden
            this.Write("using Common;\r\nusing DataAccess;\r\n\r\nnamespace Business\r\n");
            
            #line 17 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"

	}
	else
	{

            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 22 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NameSpace));
            
            #line default
            #line hidden
            this.Write(".Common;\r\nusing ");
            
            #line 23 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NameSpace));
            
            #line default
            #line hidden
            this.Write(".DataAccess;\r\n\r\nnamespace ");
            
            #line 25 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NameSpace));
            
            #line default
            #line hidden
            this.Write(".Business\r\n");
            
            #line 26 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"

	}

            
            #line default
            #line hidden
            this.Write("{\r\n\t/// <summary>\r\n\t/// ");
            
            #line 31 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("\r\n\t/// </summary>\r\n\tpublic partial class ");
            
            #line 33 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BusinessClassName));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\t#region GetByID\r\n\t\t/// <summary>\r\n\t\t/// 取得实体\r\n\t\t/// </summary>\r\n\t\t/// <pa" +
                    "ram name=\"id\">实体关键字</param>\r\n\t\t/// <returns>实体实例</returns>\r\n\t\tpublic static ");
            
            #line 41 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" Get");
            
            #line 41 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("ByID(");
            
            #line 41 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PrimaryColunm[1]));
            
            #line default
            #line hidden
            this.Write(" id)\r\n\t\t{\r\n\t\t\treturn ");
            
            #line 43 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AccessClassName));
            
            #line default
            #line hidden
            this.Write(".Get");
            
            #line 43 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("ByID(id);\r\n\t\t}\r\n\t\t#endregion\r\n\r\n\t\t#region Insert\r\n\t\t/// <summary>\r\n\t\t/// 插入数据\r\n\t\t" +
                    "/// </summary>\r\n\t\t/// <param name=\"obj");
            
            #line 51 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write("\">实体实例</param>\r\n\t\t/// <returns>true 插入成功; false 插入失败</returns>\r\n\t\tpublic static b" +
                    "ool Insert");
            
            #line 53 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 53 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" obj");
            
            #line 53 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\tif (obj");
            
            #line 55 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\t\t\t{\r\n\t\t\t\treturn false;\r\n\t\t\t}\r\n\t\t\ttry\r\n\t\t\t{\r\n\t\t\t\treturn DataAccessComm" +
                    "on.Insert(obj");
            
            #line 61 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t}\r\n\t\t\tcatch (Exception ex)\r\n\t\t\t{\r\n\t\t\t\tthrow ex;\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n" +
                    "\r\n\t\t#region Update\r\n\t\t/// <summary>\r\n\t\t/// 更新数据\r\n\t\t/// </summary>\r\n\t\t/// <param " +
                    "name=\"obj");
            
            #line 74 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write("\">实体实例</param>\r\n\t\t/// <returns>true 更新成功; false 更新失败</returns>\r\n\t\tpublic static b" +
                    "ool Update");
            
            #line 76 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 76 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" obj");
            
            #line 76 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\tif (obj");
            
            #line 78 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\t\t\t{\r\n\t\t\t\treturn false;\r\n\t\t\t}\r\n\t\t\ttry\r\n\t\t\t{\r\n\t\t\t\treturn DataAccessComm" +
                    "on.Update(obj");
            
            #line 84 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t}\r\n\t\t\tcatch (Exception ex)\r\n\t\t\t{\r\n\t\t\t\tthrow ex;\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n" +
                    "\r\n\t\t#region Delete\r\n\t\t/// <summary>\r\n\t\t/// 删除数据\r\n\t\t/// </summary>\r\n\t\t/// <param " +
                    "name=\"obj");
            
            #line 97 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write("\">实体实例</param>\r\n\t\t/// <returns>true 删除成功; false 删除失败</returns>\r\n\t\tpublic static b" +
                    "ool Delete");
            
            #line 99 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 99 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" obj");
            
            #line 99 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n\t\t\tif (obj");
            
            #line 101 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(" == null)\r\n\t\t\t{\r\n\t\t\t\treturn false;\r\n\t\t\t}\r\n\t\t\ttry\r\n\t\t\t{\r\n\t\t\t\treturn DataAccessComm" +
                    "on.Delete(obj");
            
            #line 107 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t}\r\n\t\t\tcatch (Exception ex)\r\n\t\t\t{\r\n\t\t\t\tthrow ex;\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n" +
                    "\r\n\t\t#region GetAll\r\n\t\t/// <summary>\r\n\t\t/// 获取所有数据\r\n\t\t/// </summary>\r\n\t\t/// <retu" +
                    "rns>返回所有数据</returns>\r\n\t\tpublic static DataSet Get");
            
            #line 121 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write("All()\r\n\t\t{\r\n\t\t\ttry\r\n\t\t\t{\r\n\t\t\t\treturn ");
            
            #line 125 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AccessClassName));
            
            #line default
            #line hidden
            this.Write(".Get");
            
            #line 125 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ReTableName));
            
            #line default
            #line hidden
            this.Write(@"All();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion

		#region GetDSByCondition
		/// <summary>
		/// 获取符合条件的DS
		/// </summary>
		/// <returns>返回DS</returns>
		public static DataSet GetDSByCondition(string strCondition)
		{
			try
			{
				return ");
            
            #line 143 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AccessClassName));
            
            #line default
            #line hidden
            this.Write(".GetDSByCondition(strCondition);\r\n\t\t\t}\r\n\t\t\tcatch (Exception ex)\r\n\t\t\t{\r\n\t\t\t\tthrow " +
                    "ex;\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n\r\n\t\t#region GetByCondition\r\n\t\t/// <summary>\r\n\t\t///" +
                    " 获取符合条件的数据实体\r\n\t\t/// </summary>\r\n\t\t/// <returns>返回数据实体</returns>\r\n\t\tpublic static" +
                    " List<");
            
            #line 157 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityClassName));
            
            #line default
            #line hidden
            this.Write("> GetByCondition(string strCondition)\r\n\t\t{\r\n\t\t\ttry\r\n\t\t\t{\r\n\t\t\t\treturn ");
            
            #line 161 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(AccessClassName));
            
            #line default
            #line hidden
            this.Write(".GetByCondition(strCondition);\r\n\t\t\t}\r\n\t\t\tcatch (Exception ex)\r\n\t\t\t{\r\n\t\t\t\tthrow ex" +
                    ";\r\n\t\t\t}\r\n\t\t}\r\n\t\t#endregion\r\n\t}\r\n\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 172 "E:\AutoCode\AutoCode\Template\BusinessTemplate.tt"


		public string NameSpace
		{
			set;
			get;
		}

        public string TableName
        {
			set;
            get;
        }

        public DataTable DtColunms
        {
			set;
            get;
        }

        public string BusinessClassName
        {
            get
            {
                return TableName.Replace("_", "");
            }
        }

        public string AccessClassName
        {
            get
            {
                return TableName.Replace("_", "") + "DA";
            }
        }

        public string EntityClassName
        {
            get
            {
                return TableName.Replace("_", "") + "Entity";
            }
        }

        public string TableClassName
        {
            get
            {
                 return TableName.Replace("_", "") + "Table";
            }
        }

        public string ReTableName
        {
            get
            {
                 return TableName.Replace("_", "");
            }
        }

        public string[] PrimaryColunm
        {
            get
            {
                string[] colum = new string[3];
                DataRow[] KeyRow = DtColunms.Select("ISPkID='1'");

                if (KeyRow.Length > 0)
                {
                    colum[0] = KeyRow[0]["ColunmName"].ToString().ToUpper();
                    colum[1] = Config.ConvertDbType(KeyRow[0]["TypeName"].ToString());
					colum[2] = KeyRow[0]["is_identity"].ToString();
                }
                else
                {
                    colum[0] = DtColunms.Rows[0]["ColunmName"].ToString().ToUpper();
                    colum[1] = Config.ConvertDbType(DtColunms.Rows[0]["TypeName"].ToString());
					colum[2] = DtColunms.Rows[0]["is_identity"].ToString();
                }
				return colum;
            }
        }



        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public class BusinessTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
