using UnityEngine;
using Zinnia.Tracking.Velocity;

public class OVRAnchorVelocityEstimator : VelocityTracker
{
    [Tooltip("The anchor from the OVRCameraRig to track velocity for.")]
    public GameObject trackedGameObject;
    [Tooltip("An optional object to consider the source relative to when retrieving velocities.")]

    public GameObject relativeTo;

    public override bool IsActive()
    {
        return trackedGameObject != null && trackedGameObject.activeInHierarchy && isActiveAndEnabled;
    }

    protected override Vector3 DoGetAngularVelocity()
    {
        switch (trackedGameObject.name)
        {
            case "CenterEyeAnchor":
                return trackedGameObject.transform.rotation * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeAngularVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
            case "LeftHandAnchor":
                return trackedGameObject.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
            case "RightHandAnchor":
                return trackedGameObject.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
        }
        return Vector3.zero;
    }

    protected override Vector3 DoGetVelocity()
    {
        switch (trackedGameObject.name)
        {
            case "CenterEyeAnchor":
                return relativeTo.transform.rotation * (OVRManager.isHmdPresent ? OVRPlugin.GetNodeAngularVelocity(OVRPlugin.Node.EyeCenter, OVRPlugin.Step.Render).FromFlippedZVector3f() : Vector3.zero);
            case "LeftHandAnchor":
                return relativeTo.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
            case "RightHandAnchor":
                return relativeTo.transform.rotation * OVRInput.GetLocalControllerAngularVelocity(OVRInput.Controller.LTouch);
        }
        return Vector3.zero;

    }
}
