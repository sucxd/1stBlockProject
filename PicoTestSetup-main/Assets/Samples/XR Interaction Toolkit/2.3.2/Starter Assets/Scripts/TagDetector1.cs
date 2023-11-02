using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDetector1 : MonoBehaviour
{
    public GameObject EndingOne;
    public GameObject EndingTwo;
    public GameObject EndingThre;
    public GameObject EndingFour;
    public GameObject EndingFive;

    string Wallet = "WalletB";
    string Gun = "Gun";
    string HandCoveringChest = "HandCoveringChest";
    string PoolOfBlood = "PoolOfBlood";
    string WoundHead = "WoundHead";
    string FitBit = "FitBit";
    string SecurityCamera = "SecurityCamera";
    string Footprint = "Footprint";
    string BrokenBottle = "BrokenBottle";
    string MallTimeTable = "MallTimeTable";
    string Phone = "Phone";

    bool WalletInside = false;
    bool GunInside = false;
    bool HandCoveringChestInside = false;
    bool PoolOfBloodInside = false;
    bool WoundHeadInside = false;
    bool FitBitInside = false;
    bool SecurityCameraInside = false;
    bool FootprintInside = false;
    bool BrokenBottleInside = false;
    bool MallTimeTableInside = false;
    bool PhoneInside = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.CompareTag(Wallet))
        {
            WalletInside = true;
        }
        else if (other.CompareTag(Gun))
        {
            GunInside = true;
            Debug.Log("Gun is inside");
        }
        else if (other.CompareTag(HandCoveringChest))
        {
            HandCoveringChestInside = true;
            Debug.Log("handecoveringchest is inside");
        }
        else if (other.CompareTag(PoolOfBlood))
        {
            PoolOfBloodInside = true;
            Debug.Log("Pool of blood is inside");
        }
        else if (other.CompareTag(WoundHead))
        {
            WoundHeadInside = true;
        }
        else if (other.CompareTag(FitBit))
        {
            FitBitInside = true;
            Debug.Log("FitBit is inside");
        }
        else if (other.CompareTag(SecurityCamera))
        {
            SecurityCameraInside = true;
        }
        else if (other.CompareTag(Footprint))
        {
            FootprintInside = true;
        }
        else if (other.CompareTag(BrokenBottle))
        {
            BrokenBottleInside = true;
        }
        else if (other.CompareTag(MallTimeTable))
        {
            MallTimeTableInside = true;
        }
        else if (other.CompareTag(Phone))
        {
            PhoneInside = true;
        }


        CheckTagsAndRun();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(Wallet))
        {
            WalletInside = false;
        }
        else if (other.CompareTag(Gun))
        {
            GunInside = false;
        }
        else if (other.CompareTag(HandCoveringChest))
        {
            HandCoveringChestInside = false;
        }
        else if (other.CompareTag(PoolOfBlood))
        {
            PoolOfBloodInside = false;
        }
        else if (other.CompareTag(WoundHead))
        {
            WoundHeadInside = false;
        }
        else if (other.CompareTag(FitBit))
        {
            FitBitInside = false;
        }
        else if (other.CompareTag(SecurityCamera))
        {
            SecurityCameraInside = false;
        }
        else if (other.CompareTag(Footprint))
        {
            FootprintInside = false;
        }
        else if (other.CompareTag(BrokenBottle))
        {
            BrokenBottleInside = false;
        }
        else if (other.CompareTag(MallTimeTable))
        {
            MallTimeTableInside = false;
        }
        else if (other.CompareTag(Phone))
        {
            PhoneInside = false;
        }

        CheckTagsAndRun();
    }



    private void CheckTagsAndRun()
    {
        if (HandCoveringChestInside && FitBitInside && PoolOfBloodInside && GunInside)
        {
            EndingOne.SetActive(true);
        }
        else
        {
            EndingOne.SetActive(false);
        }

        if (WoundHeadInside && FitBitInside && SecurityCameraInside && FootprintInside)
        {
            EndingTwo.SetActive(true);
        }
        else
        {
            EndingTwo.SetActive(false);
        }

        if (FootprintInside && SecurityCameraInside && BrokenBottleInside && PoolOfBloodInside)
        {
            EndingThre.SetActive(true);
        }
        else
        {
            EndingThre.SetActive(false);
        }

        if (MallTimeTableInside && PhoneInside && WalletInside && GunInside)
        {
            EndingFour.SetActive(true);
        }
        else
        {
            EndingFour.SetActive(false);
        }

        if (PhoneInside && WalletInside && SecurityCameraInside && BrokenBottleInside)
        {
            EndingFive.SetActive(true);
        }
        else
        {
            EndingFive.SetActive(false);
        }
    }

}
