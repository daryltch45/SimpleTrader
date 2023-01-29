using SimpleTrader.Domain.Model;
using SimpleTrader.Domain.Service;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
  public class MajorIndexViewModel
  {
    private readonly IMajorIndexService _majorIndexService; 
    public MajorIndex AAPL { get; set; }
    public MajorIndex FONR { get; set; }
    public MajorIndex MNKD { get; set; }


    public MajorIndexViewModel(IMajorIndexService majorIndexService)
    {
      _majorIndexService = majorIndexService;
    }
    //Reason why we initialised a new function for the lading of datas: 
    //If we initialize it in the constructor, we are gonna wait the Informations to be loaded, every single time, we will inintilize MajrindexViewModel.
    //but in this way, we can get our MajorindexViewModel then load the informations
    public static MajorIndexViewModel LoadMajorIndexViewModel(IMajorIndexService majorIndexService)
    {
      MajorIndexViewModel majorIndexViewModel = new MajorIndexViewModel(majorIndexService);
      majorIndexViewModel.LoadMajorIndexes();
      return majorIndexViewModel; 
    }
    private void LoadMajorIndexes()
    {
      _majorIndexService.GetMajorIndex(MajorIndexType.AAPL).ContinueWith((task) =>
      {
        if(task.Exception == null)
        {
          AAPL = task.Result; 
        }
      });

      _majorIndexService.GetMajorIndex(MajorIndexType.FONR).ContinueWith((task) =>
      {
        if (task.Exception == null)
        {
          FONR = task.Result;
        }
      });

      _majorIndexService.GetMajorIndex(MajorIndexType.MNKD).ContinueWith((task) =>
      {
        if (task.Exception == null)
        {
          MNKD = task.Result;
        }
      });
    }
  }
}
