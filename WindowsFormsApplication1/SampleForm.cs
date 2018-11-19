using Autofac;
using Entities;
using Presenters.Presenters;
using Presenters.Views;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SampleForm : Form, ISampleView
    {
        private SamplePresenter.Factory _presenterFactory { get; set; }

        private ViewPresenterBase<ISampleView> _presenter;

        public SampleForm()
        {
            InitializeComponent();
            var container = Autofac.AutofacBuilder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                _presenterFactory = scope.Resolve<SamplePresenter.Factory>();
                _presenter = _presenterFactory(this);
            }
            _presenter.InitView();
        }

        public SampleData Data
        {
            get => new SampleData
                    {
                        SampleProperty = lblData.Text
                    };

            set => lblData.Text = value.SampleProperty;
        }
    }
}
