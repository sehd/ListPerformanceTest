using Android.App;
using Android.OS;
using Android.Support.V7.App;
using ListPerformanceTest.Business;
using static ListPerformanceTest.AndroidNative.RecyclerViewAdapter;
using Android.Views;
using Android.Support.V7.Widget;
using Android.Content;

namespace ListPerformanceTest.AndroidNative
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IItemClickListener
    {
        private RecyclerViewAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            RecyclerView recyclerView = FindViewById<RecyclerView>(Resource.Id.rvNumbers);
            int numberOfColumns = 3;
            recyclerView.SetLayoutManager(new GridLayoutManager(this, numberOfColumns));
            adapter = new RecyclerViewAdapter(this, new Business.Loader().LoadData());
            adapter.SetClickListener(this);
            recyclerView.SetAdapter(adapter);
        }

        public void OnItemClick(View view, DataItem item)
        {
            var intent = new Intent(this, typeof(DetailsActivity));
            intent.PutExtra("data", item.Serialize());
            StartActivity(intent);
        }
    }
}

