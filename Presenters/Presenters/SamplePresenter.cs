using IServices;
using Presenters.Views;

namespace Presenters.Presenters
{
    public class SamplePresenter : ViewPresenterBase<ISampleView>
    {
        private ISampleService _sampleService;

        public SamplePresenter(ISampleView view, ISampleService sampleService) : base(view)
        {
            _sampleService = sampleService;
        }

        public delegate SamplePresenter Factory(ISampleView view);

        public override void InitView()
        {
            _view.Data = _sampleService.GetData();
        }
    }
}
