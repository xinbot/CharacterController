using UnityEngine;
using UnityEditor;

namespace KinematicCharacterController
{
    [CustomEditor(typeof(KinematicCharacterMotor))]
    public class KinematicCharacterMotorEditor : Editor
    {
        protected virtual void OnSceneGUI()
        {
            KinematicCharacterMotor motor = target as KinematicCharacterMotor;
            if (motor)
            {
                var trans = motor.transform;
                var transUp = trans.up;
                Vector3 characterBottom = trans.position +
                                          (motor.Capsule.center + (-Vector3.up * (motor.Capsule.height * 0.5f)));

                Handles.color = Color.yellow;
                Handles.CircleHandleCap(
                    0,
                    characterBottom + (transUp * motor.MaxStepHeight),
                    Quaternion.LookRotation(transUp, trans.forward),
                    motor.Capsule.radius + 0.1f,
                    EventType.Repaint);
            }
        }
    }
}