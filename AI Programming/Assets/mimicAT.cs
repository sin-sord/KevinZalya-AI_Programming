using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class mimicAT : ActionTask {

		public Transform targetTransform;
		public float zOffSet;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			Vector3 mirrorVector = new Vector3(targetTransform.position.x, targetTransform.transform.position.y, -zOffSet * targetTransform.transform.position.z);
			agent.transform.position = mirrorVector;

            Vector3 mirrorRotate = new Vector3(targetTransform.localRotation.x, targetTransform.transform.localRotation.y, targetTransform.transform.localRotation.z);

		//	if(agent.transform.localEulerAngles  mirrorRotate)
		//	{
				agent.transform.Rotate(mirrorRotate);
		//	}
			

        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}