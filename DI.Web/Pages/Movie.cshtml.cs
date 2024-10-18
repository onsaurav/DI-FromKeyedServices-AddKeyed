using DI.Web.Pages;
using DI.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DI.Web.Pages
{
    public class MovieModel : PageModel
    {
        private readonly ILogger<MovieModel> _logger; 
        private readonly IDataRepository _dataRepository;
        
        public List<dynamic> _movieList { get; set; } = new List<dynamic>();

        public MovieModel(ILogger<MovieModel> logger, [FromKeyedServices("movie")] IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public void OnGet()
        {
            _movieList = _dataRepository.GetList();
        }
    }
}
