CREATE PROCEDURE[dbo].[spUsers_BulkInsert]
@users UsersDataTable readonly
AS
BEGIN

INSERT INTO dbo.Userss(FirstName, LastName, CreateDate)
SELECT[FirstName], [LastName], [CreateDate]
FROM @users;

end