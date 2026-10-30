# 酒店管理系统 - 数据库核心操作封装

## 项目说明
本项目为《小型MIS系统》课程实践的底层核心代码展示。
由于完整项目包含大量本地UI设计文件、第三方皮肤库及本地环境配置，为保持代码仓库整洁及保护个人隐私，此处仅提取并重构展示了**最核心的数据库交互底层封装逻辑**。

## 核心代码说明
* `DatabaseHelper.cs`：封装了基于 C# 与 SQL Server 数据库的基础交互方法。
  * `ExecuteSql()`：支持执行 Insert、Update、Delete 等非查询 SQL 语句，返回受影响行数，并包含 `try-catch` 异常捕获与连接关闭机制。
  * `GetDataSet()`：支持执行 Select 查询语句，利用 `SqlDataAdapter` 将结果填充至 `DataSet` 中返回，供前端 UI 绑定使用。

## 技术栈
* 编程语言：C#
* 数据库：SQL Server
* 核心技术：ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)、面向对象封装、异常处理 (try-catch-finally)。

## 学习
* 理解“代码复用”原则，通过封装 Helper 类，大幅减少了业务层重复编写连接和操作数据库的冗余代码。
* 了解了 ADO.NET 的核心组件使用，理解了连接池与资源释放（Close）的重要性，确保系统在频繁交互时的稳定性。
