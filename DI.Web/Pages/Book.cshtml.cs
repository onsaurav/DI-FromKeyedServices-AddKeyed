using DI.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI.Web.Pages
{
    public class BookModel : PageModel
    {
        private readonly ILogger<BookModel> _logger;
        private readonly IDataRepository _dataRepository;

        public List<dynamic> _bookList { get; set; } = new List<dynamic>();

        public BookModel(ILogger<BookModel> logger, [FromKeyedServices("book")] IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public void OnGet()
        {
            _bookList = _dataRepository.GetList();
        }
    }
}
