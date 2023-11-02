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

    public string Wallet = "WalletB";
    public string Gun = "Gun";
    public string HandCoveringChest = "HandCoveringChest";
    public string PoolOfBlood = "PoolOfBlood";
    public string WoundHead = "WoundHead";
    public string FitBit = "FitBit";
    public string SecurityCamera = "SecurityCamera";
    public string Footprint = "Footprint";
    public string BrokenBottle = "BrokenBottle";
    public string MallTimeTable = "MallTimeTable";
    public string Phone = "Phone";

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
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Wallet))
        {
            WalletInside = true;
        }
        else { WalletInside = false; }

        if (other.CompareTag(Gun))
        {
            GunInside = true;
        }
        else { GunInside = false; }

        if (other.CompareTag(HandCoveringChest))
        {
            HandCoveringChestInside = true;
        }
        else { HandCoveringChestInside = false; }

        if (other.CompareTag(PoolOfBlood))
        {
            PoolOfBloodInside = true;
        }
        else { PoolOfBloodInside = false; }

        if (other.CompareTag(WoundHead))
        {
            WoundHeadInside = true;
        }
        else { WoundHeadInside = false; }

        if (other.CompareTag(FitBit))
        {
            FitBitInside = true;
        }
        else { FitBitInside = false; }

        if (other.CompareTag(SecurityCamera))
        {
            SecurityCameraInside = true;
        }
        else { SecurityCameraInside = false; }

        if (other.CompareTag(Footprint))
        {
            FootprintInside = true;
        }
        else { FootprintInside = false; }

        if (other.CompareTag(BrokenBottle))
        {
            BrokenBottleInside = true;
        }
        else { BrokenBottleInside = false; }

        if (other.CompareTag(MallTimeTable))
        {
            MallTimeTableInside = true;
        }
        else { MallTimeTableInside = false; }

        if (other.CompareTag(Phone))
        {
            PhoneInside = true;
        }
        else { PhoneInside = false; }

        CheckTagsAndRun();
    }


    private void CheckTagsAndRun()
    {
        if (HandCoveringChestInside && FitBitInside && PoolOfBloodInside && GunInside)
        {
            EndingOne.SetActive(true);
        }
        if (WoundHeadInside && FitBitInside && SecurityCameraInside && FootprintInside)
        {
            EndingTwo.SetActive(true);
        }
        if (FootprintInside && SecurityCameraInside && BrokenBottleInside && PoolOfBloodInside)
        {
            EndingThre.SetActive(true);
        }
        if (MallTimeTableInside && PhoneInside && WalletInside && GunInside)
        {
            EndingFour.SetActive(true);
        }
        if (PhoneInside && WalletInside && SecurityCameraInside && BrokenBottleInside)
        {
            EndingFive.SetActive(true);
        }
    }
}
