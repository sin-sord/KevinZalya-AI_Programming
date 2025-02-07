using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class FleeAT : ActionTask {

        public Transform fleeTargetTransform;
        public BBParameter<Vector3> targetPosition;

		public float fleeDistance;

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

			//  what is the direction we're moving in?
			Vector3 distanceFromTarget = agent.transform.position - fleeTargetTransform.position;

			if(distanceFromTarget.magnitude < fleeDistance)
			{
				// how far along that direction do we want to move in?
				Vector3 target = fleeTargetTransform.position + distanceFromTarget.normalized * fleeDistance;
				targetPosition.value = target;

			}


        }

		//Called when the task is disabled.
		protected override void OnStop() {
			


		}

		//Called when the task is paused.
		protected override void OnPause() {
			



		}
	}
}