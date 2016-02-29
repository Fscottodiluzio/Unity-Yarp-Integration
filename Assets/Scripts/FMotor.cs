using UnityEngine;
using System.Collections;

public class FMotor : DeviceDriver
{
	
	/**
     * Get the number of controlled axes. This command asks the number of controlled
     * axes for the current physical interface.
     * @param ax pointer to storage
     * @return true/false.
     */
	public virtual bool getAxes(int ax) 
	{
		ax = 2;
		Debug.Log ("FakeMotor reporting " + ax + " axes present");
		return true;
	}
	
	/** Set position mode. This command
     * is required by control boards implementing different
     * control methods (e.g. velocity/torque), in some cases
     * it can be left empty.
     * return true/false on success/failure
     */
	public virtual bool setPositionMode() {
		return true;
	}
	
	/** Set new reference point for a single axis.
     * @param j joint number
     * @param ref specifies the new ref point
     * @return true/false on success/failure
     */
	public virtual bool positionMove(int j, double refVal) {
		return true;
	}
	
	
	/** Set new reference point for all axes.
     * @param refs array, new reference points.
     * @return true/false on success/failure
     */
	public virtual bool positionMove(double refs) {
		return true;
	}
	
	
	/** Set relative position. The command is relative to the 
     * current position of the axis.
     * @param j joint axis number
     * @param delta relative command
     * @return true/false on success/failure
     */
	public virtual bool relativeMove(int j, double delta) {
		return true;
	}
	
	
	/** Set relative position, all joints.
     * @param deltas pointer to the relative commands
     * @return true/false on success/failure
     */
	public virtual bool relativeMove(double deltas) {
		return true;
	}
	
	
	/** Check if the current trajectory is terminated. Non blocking.
     * @return true if the trajectory is terminated, false otherwise
     */
	public virtual bool checkMotionDone(int j, bool flag) {
		return true;
	}
	
	
	/** Check if the current trajectory is terminated. Non blocking.
     * @return true if the trajectory is terminated, false otherwise
     */
	public virtual bool checkMotionDone(bool flag) {
		return true;
	}
	
	
	/** Set reference speed for a joint, this is the speed used during the
     * interpolation of the trajectory.
     * @param j joint number
     * @param sp speed value
     * @return true/false upon success/failure
     */
	public virtual bool setRefSpeed(int j, double sp) {
		return true;
	}
	
	
	/** Set reference speed on all joints. These values are used during the
     * interpolation of the trajectory.
     * @param spds pointer to the array of speed values.
     * @return true/false upon success/failure
     */
	public virtual bool setRefSpeeds(double spds) {
		return true;
	}
	
	
	/** Set reference acceleration for a joint. This value is used during the
     * trajectory generation.
     * @param j joint number
     * @param acc acceleration value
     * @return true/false upon success/failure
     */
	public virtual bool setRefAcceleration(int j, double acc) {
		return true;
	}
	
	
	/** Set reference acceleration on all joints. This is the valure that is
     * used during the generation of the trajectory.
     * @param accs pointer to the array of acceleration values
     * @return true/false upon success/failure
     */
	public virtual bool setRefAccelerations(double accs) {
		return true;
	}
	
	
	/** Get reference speed for a joint. Returns the speed used to 
     * generate the trajectory profile.
     * @param j joint number
     * @param ref pointer to storage for the return value
     * @return true/false on success or failure
     */
	public virtual bool getRefSpeed(int j, double refVal) {
		return true;
	}
	
	
	/** Get reference speed of all joints. These are the  values used during the
     * interpolation of the trajectory.
     * @param spds pointer to the array that will store the speed values.
     */
	public virtual bool getRefSpeeds(double spds) {
		return true;
	}
	
	
	/** Get reference acceleration for a joint. Returns the acceleration used to 
     * generate the trajectory profile.
     * @param j joint number
     * @param acc pointer to storage for the return value
     * @return true/false on success/failure
     */
	public virtual bool getRefAcceleration(int j, double acc) {
		return true;
	}
	
	
	/** Get reference acceleration of all joints. These are the values used during the
     * interpolation of the trajectory.
     * @param accs pointer to the array that will store the acceleration values.
     * @return true/false on success or failure 
     */
	public virtual bool getRefAccelerations(double accs) {
		return true;
	}
	
	
	/** Stop motion, single joint
     * @param j joint number
     * @return true/false on success/failure
     */
	public virtual bool stop(int j) {
		return true;
	}
	
	
	/** Stop motion, multiple joints 
     * @return true/false on success/failure
     */
	public virtual bool stop() {
		return true;
	}
	
	
	public virtual bool open(Searchable config) {
		return true;
	}
	
	public virtual bool close() {
		return true;
	}
	
	public void testMotor(PolyDriver driver) 
	{
		IPositionControl pos = driver.viewIPositionControl ();
		if (pos != null) 
		{
			int ct = pos.getAxes();
			Debug.Log("Number of axes is " + ct);
		} 
		else 
		{
			Debug.Log("Could not find IPositionControl interface");
		}
	}
};