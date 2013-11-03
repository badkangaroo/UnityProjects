if(ObjectTarget){
float distance = Vector3.Distance(ObjectTarget.transform.position,this.gameObject.transform.position);
// If the distance is less than 2 then look at the target and attack
if(distance<=2){
	// If the distance is greater then look at the target and move forward
		Attack(aiState);
}else{
		Approach(aiState)
}
void Attack(int state) {
	transform.LookAt(ObjectTarget.transform.position);
	if(aiTime<=0){
		if(state == 1){
			character.Attack();
		}
	}
}
void Approach(int state) {
	if(state == 1){
		transform.LookAt(ObjectTarget.transform.position);
		direction = this.transform.forward;
		direction.Normalize();  // what is Vector3.Normalize();
		character.Move(direction);
	}
}