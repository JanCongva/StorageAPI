using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using StorageAPI.Entities;
using StorageAPI.Services;

namespace StorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : ControllerBase
    {
        private readonly IStorageTypeFactory _storageTypeFactory;
        private readonly IStorageType _storageType;

        public DocumentsController(IStorageTypeFactory storageTypeFactory)
        {
            _storageTypeFactory = storageTypeFactory;
            _storageType = _storageTypeFactory.CreateStorageType();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult PostDocument([FromBody] Document document)
        {
            var result = _storageType.PostDocument(document);
            return Ok(result);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetDocument(string id)
        {
            var filepath = _storageType.GetDocument(id);

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(filepath, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }

            var bytes = await System.IO.File.ReadAllBytesAsync(filepath);

            return File(bytes, contenttype, Path.GetFileName(filepath));
        }
    }
}