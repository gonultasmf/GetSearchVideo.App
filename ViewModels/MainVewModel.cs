using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GetSearchVideo.Models;
using GetSearchVideo.Services;

namespace GetSearchVideo.ViewModels;

public partial class MainVewModel : ObservableObject
{
    ISearchService _searchService = new SearchService();

    [ObservableProperty]
    private string _searchText;

    [ObservableProperty]
    private List<Video> _listResult;

    public MainVewModel()
    {

    }

    [RelayCommand]
    public async void GetVideos()
    {
        var searchText = SearchText.Replace(' ', '+');
        ListResult = await _searchService.GetVideoBySearch(searchText);
    }
}
