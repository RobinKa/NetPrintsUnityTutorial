namespace NetPrintsUnityTutorial
            {
                class PlayerController : UnityEngine.MonoBehaviour
                {
                    public System.Single speed;
UnityEngine.Rigidbody rb;
void FixedUpdate()
{
System.Exception varException;
System.Single varSingle;
System.Exception varException2;
System.Single varSingle2;
UnityEngine.Vector3 varVector3;
System.Exception varException3;
UnityEngine.Vector3 varVector32;
System.Exception varException4;
UnityEngine.Rigidbody varRigidbody;
System.Single varSingle3;
System.Single varData0;
System.Single varData02;

goto State0;

State0:
varSingle = UnityEngine.Input.GetAxis("Horizontal");
goto State1;

State1:
varSingle2 = UnityEngine.Input.GetAxis("Vertical");
goto State2;

State2:
varData02 = varSingle;
varData0 = varData02;
varVector3 = new UnityEngine.Vector3(varData0, 0F, varSingle2);
goto State3;

State3:
varSingle3 = this.speed;
varVector32 = varVector3*varSingle3;
goto State4;

State4:
varRigidbody = this.rb;
varRigidbody.AddForce(varVector32);
goto State5;

State5:
return;

}

void Start()
{
System.Exception varException;
UnityEngine.Component varComponent;
UnityEngine.Rigidbody varCastObject;
UnityEngine.Rigidbody varRigidbody;
System.Type varType;

goto State0;

State0:
varType = typeof(UnityEngine.Rigidbody);
varComponent = this.GetComponent(varType);
goto State1;

State1:
if (varComponent is UnityEngine.Rigidbody)
{
varCastObject = (UnityEngine.Rigidbody)varComponent;
goto State2;
}
else
return;

State2:
this.rb = varCastObject;
varRigidbody = varCastObject;
goto State3;

State3:
return;

}


                }
            }