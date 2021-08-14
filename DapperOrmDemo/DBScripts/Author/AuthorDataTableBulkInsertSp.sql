CREATE PROCEDURE[dbo].[spAuthors_BulkInsert]
@authors AuthorDataTable readonly
AS
BEGIN

INSERT INTO dbo.Authors(FirstName, LastName, Age, Comment, Comment1, Comment2, Comment3, Comment4, Comment5, Comment6, Comment7, Comment8, Comment9, Comment10, Comment11, Comment12, Comment13, Comment14, Comment15)
SELECT[FirstName], [LastName], [Age], [Comment], [Comment1], [Comment2], [Comment3], [Comment4], [Comment5], [Comment6], [Comment7], [Comment8], [Comment9], [Comment10], [Comment11], [Comment12], [Comment13], [Comment14], [Comment15]
FROM @authors;

end