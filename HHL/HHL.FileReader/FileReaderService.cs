using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace HHL.FileReader
{

    public interface IFileReaderServiceOptions
    {
        bool InitializeOnFirstCall { get; set; }
    }

    internal class FileReaderServiceOptions : IFileReaderServiceOptions
    {
        public bool InitializeOnFirstCall { get; set; } = false;
    }

    public interface IFileReaderService
    {
        Task EnsureInitializedAsync();

        IFileReaderRef CreateReference(ElementRef inputFileElement);
    }

    public class FileReaderService : IFileReaderService
    {
        private static bool _needsInitialization = false;

        private readonly FileReaderJsInterop _fileReaderJsInterop;

        public FileReaderService(IJSRuntime jsRuntime, IFileReaderServiceOptions options)
        {
            this.Options = options;
            this._fileReaderJsInterop = new FileReaderJsInterop(jsRuntime, options.InitializeOnFirstCall);
        }

        public IFileReaderServiceOptions Options { get; }

        public IFileReaderRef CreateReference(ElementRef inputFileElement)
        {
            return new FileReaderRef(inputFileElement, this._fileReaderJsInterop);
        }

        public async Task EnsureInitializedAsync()
        {
            if (!_needsInitialization)
            {
                return;
            }

            await this._fileReaderJsInterop.EnsureInitializedAsync();
            _needsInitialization = false;
        }

    }
}
