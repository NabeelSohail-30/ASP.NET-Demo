<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Db12_SqlInjection.aspx.cs" Inherits="CsharpWebAppDemo.Database.Db12_SqlInjection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>SQL Injection (SQLi)</h1>
        <p>SQL injection is a web security vulnerablity that allows an attacker to interfere with the queries that an application makes to its database.</p>
        <p>- View Data that they are normally able to retreive.</p>
        <p>- Modity</p>
        <p>- Delete </p>
        <p>- Add</p>
        <p>- DB Operations</p>
        <p>Sql Injection: (to bypass conditions)</p>

    </div>
    </form>
    <p>
        abc&#39; OR 1=1) --</p>
    <p>
        SELECT AuthorId, AuthorName FROM ListAuthor WHERE (AuthorName LIKE &#39;%mufti&#39; OR 1=1) UNION sELECT CategoryId, Category from dbo.ListCategory --%&#39;)</p>
    <p>
        mufti&#39; OR 1=1) UNION SELECT 1 AS Id, TABLE_NAME from INFORMATION_SCHEMA.TABLES -- (Passed in Form)</p>
    <p>
        &nbsp;</p>
    <h1>How to avoid SQli Attack</h1>

    <p>
        1. Using Validation (if Application does not support method 2 and 3)</p>
    <p>
        Attack using comment (--)</p>
    <p>
        Validate &#39;--&#39; keyword in input.</p>
    <p>
        Disadvantages:</p>
    <p>
        a. 100&#39;s of validations</p>
    <p>
        b. Application processing compromise</p>
    <p>
        c. Few valid data will be treated as SQLi. If password has = sign then it will treat as SQLi attack, Oralndo, Andrew, Orhan</p>
    <p>
        2. Parameterized Queries</p>
    <p>
        3. SQL Server Stored Procedures</p>

</body>
</html>
