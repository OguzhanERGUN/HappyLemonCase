using UnityEngine;

public class CubeController : MonoBehaviour
{
	// Update is called once per frame

	private bool isMoving;
	private Vector3 movementVector = Vector3.back;
	private float zBorder = 0;
	private float rayDistance = 1f;
	[SerializeField] private float speed;
	[SerializeField] private LayerMask cubeLayer;

	void Update()
	{

	}
	void FixedUpdate() // Fizik iþlemleri için FixedUpdate daha iyidir
	{
		if (transform.position.z < zBorder) return;

		// Küpün kendi pozisyonundan ileri doðru (örneðin lokal z ekseni) bir ýþýn at
		RaycastHit hit;
		// `transform.forward` küpün lokal Z ekseni yönüdür
		if (Physics.Raycast(transform.position, movementVector, out hit, rayDistance, cubeLayer))
		{
			// Iþýn bir þeye çarptý!
			Debug.Log($"Hit an obstacle: {hit.collider.name} at distance {hit.distance}");
			isMoving = false; // Dur
							  // Ýsterseniz burada hafifçe geri çekilme veya yavaþlama animasyonu ekleyebilirsiniz
		}
		else
		{
			transform.Translate(movementVector * Time.fixedDeltaTime * speed);
			isMoving = true;

		}
	}
}
