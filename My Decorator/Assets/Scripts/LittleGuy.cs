using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LittleGuy : MonoBehaviour
{
    public bool tH = false;
    public bool f = false;
    public bool cW = false;
    public bool n = false;
    public bool s = false;
    public bool bT = false;

    public GameObject topHatO;
    public GameObject friendO;
    public GameObject wigO;
    public GameObject noseO;
    public GameObject scarfO;
    public GameObject bowTieO;

    public TMP_Text displayText;

    public void Enter()
    {
        IGuy guy = new Guy();

        if (tH == true)
        {
            IGuy tophatDecorator = new TopHatDecorator(guy);

            if (bT == true)
            {
                IGuy bowTieDecorator = new BowtieDecorator(tophatDecorator);
                displayText.text = bowTieDecorator.GetGuyType();
                topHatO.SetActive(true);
                bowTieO.SetActive(true);
            }
            if (s == true)
            {
                IGuy scarfDecorator = new ScarfDecorator(tophatDecorator);
                displayText.text = scarfDecorator.GetGuyType();
                topHatO.SetActive(true);
                scarfO.SetActive(true);
            }
            if (n == true)
            {
                IGuy noseDecorator = new NoseDecorator(tophatDecorator);
                displayText.text = noseDecorator.GetGuyType();
                topHatO.SetActive(true);
                noseO.SetActive(true);
            }
        }

        if (cW == true)
        {
            IGuy clownwigDecorator = new WigDecorator(guy);

            if (bT == true)
            {
                IGuy bowTieDecorator = new BowtieDecorator(clownwigDecorator);
                displayText.text = bowTieDecorator.GetGuyType();
                wigO.SetActive(true);
                bowTieO.SetActive(true);
            }
            if (s == true)
            {
                IGuy scarfDecorator = new ScarfDecorator(clownwigDecorator);
                displayText.text = scarfDecorator.GetGuyType();
                wigO.SetActive(true);
                scarfO.SetActive(true);
            }
            if (n == true)
            {
                IGuy noseDecorator = new NoseDecorator(clownwigDecorator);
                displayText.text = noseDecorator.GetGuyType();
                wigO.SetActive(true);
                noseO.SetActive(true);
            }
        }

        if (f == true)
        {
            IGuy friendDecorator = new FriendDecorator(guy);

            if (bT == true)
            {
                IGuy bowTieDecorator = new BowtieDecorator(friendDecorator);
                displayText.text = bowTieDecorator.GetGuyType();
                friendO.SetActive(true);
                bowTieO.SetActive(true);
            }
            if (s == true)
            {
                IGuy scarfDecorator = new ScarfDecorator(friendDecorator);
                displayText.text = scarfDecorator.GetGuyType();
                friendO.SetActive(true);
                scarfO.SetActive(true);
            }
            if (n == true)
            {
                IGuy noseDecorator = new NoseDecorator(friendDecorator);
                displayText.text = noseDecorator.GetGuyType();
                friendO.SetActive(true);
                noseO.SetActive(true);
            }
        }

    }

    public void Reset()
    {
        tH = false;
        cW = false;
        f = false;
        bT = false;
        s = false;
        n = false;

        topHatO.SetActive(false);
        scarfO.SetActive(false);
        bowTieO.SetActive(false);
        noseO.SetActive(false);
        friendO.SetActive(false);
        wigO.SetActive(false);

        displayText.text = " ";
    }

    public void TopHat()
    {
        tH = true;
        cW = false;
        f = false;
    }

    public void ClownWig()
    {
        cW = true;
        tH = false;
        f = false;
    }

    public void Friend()
    {
        f = true;
        cW = false;
        tH = false;
    }

    public void Bowtie()
    {
        bT = true;
        s = false;
        n = false;
    }
    public void Scarf()
    {
        s = true;
        bT = false;
        n = false;
    }

    public void Nose()
    {
        n = true;
        s = false;
        bT = false;
    }

    interface IGuy
    {
        string GetGuyType();
    }
    public class Guy : IGuy
    {
        public string GetGuyType()
        {
            return "The little guy has been swagged up";
        }
    }

    class GuyDecorator : IGuy
    {
        private IGuy _guy;

        public GuyDecorator(IGuy guy)
        {
            _guy = guy; 
        }
        public  virtual string GetGuyType()
        {
            return _guy.GetGuyType();
        }
    }

    class TopHatDecorator: GuyDecorator
    {
        public TopHatDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " with a daper hat";

            return type;
        }
    }

    class WigDecorator : GuyDecorator
    {
        public WigDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " with a funny wig";

            return type;
        }
    }

    class FriendDecorator : GuyDecorator
    {
        public FriendDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " with a little friend";

            return type;
        }
    }

    class BowtieDecorator : GuyDecorator
    {
        public BowtieDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " and a handsome bowtie.";

            return type;
        }
    }

    class NoseDecorator : GuyDecorator
    {
        public NoseDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " and a big red nose.";

            return type;
        }
    }

    class ScarfDecorator : GuyDecorator
    {
        public ScarfDecorator(IGuy guy) : base(guy) { }

        public override string GetGuyType()
        {
            string type = base.GetGuyType();
            type += " and a warm scarf.";

            return type;
        }
    }
}
