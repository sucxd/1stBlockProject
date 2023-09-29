using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class TeleportationController : MonoBehaviour
{
    public XRController teleportController;
    public XRInteractorLineVisual lineVisual;
    public Transform headTransform;

    private bool isTeleporting = false;

    private void Update()
    {
        if (teleportController)
        {
            // Check for the button press
            if (teleportController.inputDevice.GetButton(XRButton.PrimaryButton))
            {
                if (!isTeleporting)
                {
                    // Start teleportation
                    lineVisual.enabled = true;
                    isTeleporting = true;
                }
            }
            else
            {
                if (isTeleporting)
                {
                    // Perform teleportation
                    TryTeleport();
                    lineVisual.enabled = false;
                    isTeleporting = false;
                }
            }
        }
    }

    private void TryTeleport()
    {
        // Perform teleportation logic
    }
}
