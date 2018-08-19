using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace ListPerformanceTest.AndroidNative
{
    [Activity(Label = "DetailsActivity", Theme = "@style/AppTheme")]
    public class DetailsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_details);
            var image = FindViewById<ImageView>(Resource.Id.item_image);
            var text = FindViewById<TextView>(Resource.Id.item_name);
            var data = Intent.GetStringExtra("data").Deserialize();
            image.SetImageResource(data.ImageId.GetResourceId());
            text.Text = data.Name;
        }
    }
}