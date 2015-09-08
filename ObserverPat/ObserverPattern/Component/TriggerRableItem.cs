using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GOFClassLibrary.BehavioralPatterns.ObserverPattern;

using WindowsFormsApplication4.Properties;


namespace WindowsFormsApplication4.Component
{    
    
    public enum Status{on,off}
    abstract class TriggerRableItem : Control
    {
        
        protected Image onImage { get; set; }
        protected Image offImage { get; set; }
        private Status _itemState = Status.off;
        public Status itemState
        {
            get { return _itemState; }
            set { 
                if (_itemState == value)
                    return;
                 _itemState = value;
                 Invalidate(); 
                }
        }
        public TriggerRableItem(Image on, Image off)
        {
            this.onImage = on;
            this.offImage = off;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Image img = itemState == Status.on ? onImage : offImage;
            pe.Graphics.DrawImage(img, ClientRectangle);
        }
    }
    class Switch : TriggerRableItem 
    {
        public ObserverManager observerManager = new ObserverManager();
        
        public Switch()
        : base(Resources.onSwitch, WindowsFormsApplication4.Properties.Resources.offSwitch)
        {
           
            Size = new Size(130, 40);
      
        }
        protected override void OnClick(EventArgs e)
        {
           
            itemState = itemState == Status.on ?  Status.off :  Status.on;
            observerManager.Notify(itemState);
         
        }
    }
    class Light : TriggerRableItem, Iobserver
    {
      int nbSource { get; set; }
        public Light()
            : base(Resources.onFlash, WindowsFormsApplication4.Properties.Resources.offFlash)
        {
            Size = new Size(50, 70);
            nbSource = 0;
    
        }


        public void update<S>(S sub)
        {
            
            nbSource += (dynamic)sub == Status.on ? 1 : -1;
            this.itemState = nbSource > 0 ? Status.on : Status.off;
        }
    }

}
