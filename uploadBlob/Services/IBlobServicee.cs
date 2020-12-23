using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace uploadBlob.Services
{
    public interface IBlobServicee
    {
        public Task<Uri> UploadFileBlobAsync(string blobContainerName, Stream content, string contentType, string fileName);



    }
}
