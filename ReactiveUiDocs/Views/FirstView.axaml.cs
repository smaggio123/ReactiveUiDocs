using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUiDocs.ViewModels;
using System.Reactive.Disposables;

namespace ReactiveUiDocs.Views
{
    public partial class FirstView : ReactiveUserControl<FirstViewModel>
    {
        public FirstView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.PathTextBlock.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
