using GetSearchVideo.Models;

namespace GetSearchVideo.Services;

public interface ISearchService
{
    Task<List<Video>> GetVideoBySearch(string searchText);
}
