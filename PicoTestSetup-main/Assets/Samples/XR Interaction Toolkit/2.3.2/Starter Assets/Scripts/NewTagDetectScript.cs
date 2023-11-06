using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTagDetectScript : MonoBehaviour
{
    public GameObject EndingOne;
    public GameObject EndingTwo;
    public GameObject EndingThree;
    public GameObject EndingFour;
    public GameObject EndingFive;

    // Tags
    private const string WalletTag = "WalletB";
    private const string GunTag = "Gun";
    private const string HandCoveringChestTag = "HandCoveringChest";
    private const string PoolOfBloodTag = "PoolOfBlood";
    private const string WoundHeadTag = "WoundHead";
    private const string FitBitTag = "FitBit";
    private const string SecurityCameraTag = "SecurityCamera";
    private const string FootprintTag = "Footprint";
    private const string BrokenBottleTag = "BrokenBottle";
    private const string MallTimeTableTag = "MallTimeTable";
    private const string PhoneTag = "Phone";

    // Flags for tag detection
    private bool WalletInside;
    private bool GunInside;
    private bool HandCoveringChestInside;
    private bool PoolOfBloodInside;
    private bool WoundHeadInside;
    private bool FitBitInside;
    private bool SecurityCameraInside;
    private bool FootprintInside;
    private bool BrokenBottleInside;
    private bool MallTimeTableInside;
    private bool PhoneInside;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case WalletTag:
                WalletInside = true;
                break;
            case GunTag:
                GunInside = true;
                Debug.Log("Gun is inside");
                break;
            case HandCoveringChestTag:
                HandCoveringChestInside = true;
                Debug.Log("HandCoveringChest is inside");
                break;
            case PoolOfBloodTag:
                PoolOfBloodInside = true;
                Debug.Log("Pool of blood is inside");
                break;
            case WoundHeadTag:
                WoundHeadInside = true;
                break;
            case FitBitTag:
                FitBitInside = true;
                Debug.Log("FitBit is inside");
                break;
            case SecurityCameraTag:
                SecurityCameraInside = true;
                break;
            case FootprintTag:
                FootprintInside = true;
                break;
            case BrokenBottleTag:
                BrokenBottleInside = true;
                break;
            case MallTimeTableTag:
                MallTimeTableInside = true;
                break;
            case PhoneTag:
                PhoneInside = true;
                break;
        }

        CheckTagsAndRun();
    }

    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case WalletTag:
                WalletInside = false;
                break;
            case GunTag:
                GunInside = false;
                break;
            case HandCoveringChestTag:
                HandCoveringChestInside = false;
                break;
            case PoolOfBloodTag:
                PoolOfBloodInside = false;
                break;
            case WoundHeadTag:
                WoundHeadInside = false;
                break;
            case FitBitTag:
                FitBitInside = false;
                break;
            case SecurityCameraTag:
                SecurityCameraInside = false;
                break;
            case FootprintTag:
                FootprintInside = false;
                break;
            case BrokenBottleTag:
                BrokenBottleInside = false;
                break;
            case MallTimeTableTag:
                MallTimeTableInside = false;
                break;
            case PhoneTag:
                PhoneInside = false;
                break;
        }

        CheckTagsAndRun();
    }

    private void CheckTagsAndRun()
    {
        EndingOne.SetActive(HandCoveringChestInside && FitBitInside && PoolOfBloodInside && GunInside);
        EndingTwo.SetActive(WoundHeadInside && FitBitInside && SecurityCameraInside && FootprintInside);
        EndingThree.SetActive(FootprintInside && SecurityCameraInside && BrokenBottleInside && PoolOfBloodInside);
        EndingFour.SetActive(MallTimeTableInside && PhoneInside && WalletInside && GunInside);
        EndingFive.SetActive(PhoneInside && WalletInside && SecurityCameraInside && BrokenBottleInside);
    }
}
