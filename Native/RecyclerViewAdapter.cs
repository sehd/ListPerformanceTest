using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using ListPerformanceTest.Business;
using static Android.Views.View;

namespace ListPerformanceTest.AndroidNative
{
    class RecyclerViewAdapter : RecyclerView.Adapter
    {
        private readonly LayoutInflater inflater;
        private IItemClickListener clickListener;

        public DataItem[] Data { get; }
        public override int ItemCount => Data.Length;

        public RecyclerViewAdapter(Context context, DataItem[] data)
        {
            inflater = LayoutInflater.From(context);
            Data = data;
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is RecyclerViewHolder rvHolder)
            {
                rvHolder.TextView.Text = Data[position].Name;
                rvHolder.ImageView.SetImageResource(Data[position].ImageId.GetResourceId());
            }

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = inflater.Inflate(Resource.Layout.list_item, parent, false);
            return new RecyclerViewHolder(view, this);
        }

        public class RecyclerViewHolder : RecyclerView.ViewHolder, IOnClickListener
        {
            public TextView TextView { get; }
            public ImageView ImageView { get; }

            private readonly RecyclerViewAdapter parent;

            public RecyclerViewHolder(View view, RecyclerViewAdapter parent) : base(view)
            {
                TextView = view.FindViewById<TextView>(Resource.Id.info_text);
                ImageView = view.FindViewById<ImageView>(Resource.Id.info_image);
                view.SetOnClickListener(this);
                this.parent = parent;
            }

            public void OnClick(View view)
            {
                if (parent.clickListener != null)
                    parent.clickListener.OnItemClick(view, parent.Data[AdapterPosition]);
            }
        }

        DataItem GetItem(int id)
        {
            return Data[id];
        }


        public void SetClickListener(IItemClickListener itemClickListener)
        {
            clickListener = itemClickListener;
        }

        public interface IItemClickListener
        {
            void OnItemClick(View view, DataItem position);
        }
    }
}