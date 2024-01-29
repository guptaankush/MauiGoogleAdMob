namespace SampleAdMob
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SetBannerId();
        }

        private void SetBannerId()
        {
#if __ANDROID__
                AdView.AdsId="ca-app-pub-Your_Android_Banner_ID";
#elif __IOS__
            AdView.AdsId = "ca-app-pub-Your_IOS_Banner_ID";
            #endif
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
