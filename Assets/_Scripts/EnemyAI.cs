using UnityEngine;
using System.Collections;

[RequireComponent (typeof (NavMeshAgent))]
public class EnemyAI : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Transform target;

	// PRIVATE INSTANCE VARIABLES
	private NavMeshAgent _agent;
	private Vector3 _destination;

	void Start () {
		this._agent = gameObject.GetComponent<NavMeshAgent> ();
		this._destination = this._agent.destination;

		this._agent.updateRotation = true;
		this._agent.updatePosition = true;
	}
	
	// Update is called once per frame
	void Update () {
		// Ensure target is at least 2 meters away
		if (Vector3.Distance (this._destination, this.target.position) > 2.0f) {
			this._destination = target.position;
			this._agent.destination = this._destination;
		}
	}
}
