using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace Brussels.FlightSearch.Droid
{
    public class NativeFlightStatusView : LinearLayout
    {
        public TextView DepatureAirportCodeTextView { get; set; }
        public TextView DepatureCityTextView { get; set; }

        public TextView ScheduledDepatureTimeTextView { get; set; }

        public TextView ActualDepatureTimeTextView { get; set; }

        public TextView ScheduledArrivalTimeTextView { get; set; }

        public TextView ActualArrivalTimeTextView { get; set; }

        public TextView ArrivalAirportCodeTextView { get; set; }
        public TextView ArrivalCityTextView { get; set; }

        public TextView FlightTimeTextView { get; set; }

        public NativeFlightStatusView(Context context) : base(context)
        {
            var view = (context as Activity).LayoutInflater.Inflate(Resource.Layout.NativeFlightStatus, null);
            DepatureAirportCodeTextView = view.FindViewById<TextView>(Resource.Id.tvDepatureAirportCode);

            DepatureCityTextView = view.FindViewById<TextView>(Resource.Id.tvDepatureCity);
            ScheduledDepatureTimeTextView = view.FindViewById<TextView>(Resource.Id.tvScheduleDepature);
            ActualDepatureTimeTextView = view.FindViewById<TextView>(Resource.Id.tvActualDepature);
            ScheduledArrivalTimeTextView = view.FindViewById<TextView>(Resource.Id.tvScheduledArrivalTime);
            ActualArrivalTimeTextView = view.FindViewById<TextView>(Resource.Id.tvActualArrivalTime);
            ArrivalAirportCodeTextView = view.FindViewById<TextView>(Resource.Id.tvArrivalAirport);
            ArrivalCityTextView = view.FindViewById<TextView>(Resource.Id.tvArrivalCity);
            FlightTimeTextView = view.FindViewById<TextView>(Resource.Id.tvFlightTime);

            this.AddView(view);
        }

        //protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        //{
        //    var rendererWidth = (int)Context.ToPixels(rendererSize.Request.Width);
        //    var rendererHeight = (int)Context.ToPixels(rendererSize.Request.Height);

            
        //    //base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        //    base.OnMeasure(345, 255);
        //}
    }
}