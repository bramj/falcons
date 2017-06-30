using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class FalconScript : MonoBehaviour
{
	public float speed = 1;
	public float force = 1;

	private Rigidbody2D rigidbodyComponent;

	void Start ()
	{
		if (rigidbodyComponent == null)
			rigidbodyComponent = GetComponent<Rigidbody2D>();
    
		rigidbodyComponent.velocity = Vector2.left * speed;
	}

	void Update ()
	{
		if (rigidbodyComponent == null)
			rigidbodyComponent = GetComponent<Rigidbody2D>();
	
		if (Random.value < 0.03)
			rigidbodyComponent.AddForce (Vector2.up * force);
	}

	void OnCollisionEnter2D (Collision2D otherCollider)
	{
		if (otherCollider.gameObject.GetComponent<PlayerScript>()) {
			Destroy (rigidbodyComponent.gameObject);
		} else if (otherCollider.gameObject.name == "Ground") {
			SpecialEffectsHelper.Instance.Splat(transform.position);
			Destroy (rigidbodyComponent.gameObject);
		}
	}
}