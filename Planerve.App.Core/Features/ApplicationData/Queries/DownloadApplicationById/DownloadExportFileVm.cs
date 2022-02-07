using Kevsoft.PDFtk;

namespace Planerve.App.Core.Features.ApplicationData.Queries.DownloadApplicationById;

public class DownloadExportFileVm
{
    public string ApplicationExportFileName { get; set; }
    public string ContentType { get; set; }
    public IPDFtkResult<byte[]> Data { get; set; }
}