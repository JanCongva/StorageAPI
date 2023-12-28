using StorageAPI.Controllers;
namespace StorageAPI.tests;

[TestClass]
public class TestDocumentsController
{
    //Demonstrate unit test
    [TestMethod]
    public void GetAllDocuments_ShouldReturnAllDocuments()
    {
        //Some testcase
    }

    [TestMethod]
    public void PostDocument(string id)
    {
        //Some testcase for POST document with id
    }

    [TestMethod]
    public void GetDocument_ShouldReturnDocumentById(string id)
    {
        //Some testcase for GET document with id
    }
}
