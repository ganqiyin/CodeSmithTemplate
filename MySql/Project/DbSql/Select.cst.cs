using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO; 
using CodeSmith.Engine;


public class SelectBehindClass : CodeTemplate{ 
/*    // 生成实体文件
    public string BuildSql()
    {
        var sql=new System.Text.StringBuilder(" SELECT ");
        //遍历数据库表的字段属性
         for (var i=0;i<this.SourceTable.Columns.Count;i++) {
                 var column=this.SourceTable.Columns[i];
                 sql.Append(column.Name);
                sql.Append((i==this.SourceTable.Columns.Count-1)?"":"," );
             } 
            sql.AppendFormat(" FROM {0}",SourceTable.Name ); 
         return sql.ToString();
    } */
}