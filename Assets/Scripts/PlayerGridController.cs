using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerGridController : MonoBehaviour
{

	public Rigidbody2D rb;
	public float moveSpeed = 5f;

	public static PlayerGridController instance;

	public string areaTransitionName;

	private Vector3 bottomLeftLimit;

	private Vector3 topRightLimit;

	public Animator anim;

	public bool canMove = true;

	public bool isWalking;
	public bool isHopping;

	public Tilemap obstruction;

	public Tilemap ground;
	public Tilemap hoppable;

	private GameObject looker;
	public Vector3Int origin;
	public Vector3Int destination;

	private float moveDuration = 0.25f;
	private Vector3Int direction = Vector3Int.zero;
	private BoxCollider2D lookerCollider;

	public PlayerMovement controls;
	private bool movePressed = false;
	private DialogLines dialog = null;

	private void Awake()
	{
		controls = new PlayerMovement();
	}

	private void OnEnable()
	{
		controls.Enable();
	}

	private void OnDisable()
	{
		controls.Disable();
	}

	void Start()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			if (instance != this)
			{
				Destroy(gameObject);
			}
		}
		DontDestroyOnLoad(gameObject);

		looker = GameObject.Find("Looker");
		lookerCollider = looker.GetComponent<BoxCollider2D>();

		controls.Walk.Movement.performed += ctx => Walk(ctx.ReadValue<Vector2>());
		controls.Walk.Movement.canceled += ctx => StopWalk();
		controls.Action.A.performed += ctx => PrintDialog(ctx.performed);
	}

	void FixedUpdate()
	{
		anim.SetFloat("x", direction.x);
		anim.SetFloat("y", direction.y);
		SetLookerDirection();

		if (!isWalking && !isHopping && movePressed)
		{
			StartCoroutine(ApplyMovement());
		}
	}

	private void Walk(Vector2 input)
	{
		movePressed = true;
		direction = new Vector3Int(Mathf.RoundToInt(input.x), Mathf.RoundToInt(input.y), 0);
	}

	private void StopWalk()
	{
		movePressed = false;
	}

	private void PrintDialog(bool isPerformed)
	{
		//this condition makes sure button is pressed once
		if (isPerformed && gameObject.scene.IsValid())
		{
			if (dialog != null)
			{
				DialogManager.instance.Dialog(dialog);
			}
		}
	}

	private IEnumerator ApplyMovement()
	{
		Vector3 pos = transform.position;
		origin = new Vector3Int(Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y), 0);
		destination = origin + direction;

		if (TileExists(obstruction, destination) && TileExists(hoppable, destination + direction))
		{
			print("Blocked");
			destination += direction;
		}
		else if (TileExists(obstruction, destination) || !TileExists(ground, destination))
		{
			destination = origin;
		}
		//RaycastHit2D hit = Physics2D.Raycast((Vector3)destination, (Vector3)direction);

		// if (hit.collider != null)
		// {
		// 	print((Vector3)hit.point);
		// 	print("dest" + (Vector3)destination);
		// 	if ((Vector3)hit.point == (Vector3)destination)
		// 	{
		// 		print("CHACHING");
		// 		destination = origin;
		// 	}
		// }
		anim.SetBool("isWalking", true);


		isWalking = true;

		float elapsedTime = 0;

		while (elapsedTime < moveDuration)
		{
			rb.MovePosition(
				Vector3
					.Lerp(origin,
					destination,
					(elapsedTime / moveDuration)));
			elapsedTime += Time.deltaTime;
			yield return null;
		}
		// transform.position = destination;

		isWalking = false;
		anim.SetBool("isWalking", false);
	}

	public void Hop(Vector3 ledgeDirection, Vector3 newDestination)
	{
		if (ledgeDirection == direction)
		{
			StartCoroutine(ApplyMovement());
		}
	}

	private bool TileExists(Tilemap tilemap, Vector3 position)
	{
		return tilemap.HasTile(tilemap.WorldToCell(position));
	}

	public void SetBounds(Vector3 bottomLeft, Vector3 topRight)
	{
		bottomLeftLimit = bottomLeft + new Vector3(0.5f, 0.5f, 0f);
		topRightLimit = topRight + new Vector3(-0.5f, -0.5f, 0f);
	}

	public void SetLookerDirection()
	{
		if (direction == Vector3Int.up)
		{
			lookerCollider.size = new Vector2(0.5f, 1.4f);
		}
		else if (direction == Vector3Int.down)
		{
			lookerCollider.size = new Vector2(0.5f, -1.4f);
		}
		else if (direction == Vector3Int.left)
		{
			lookerCollider.size = new Vector2(-1.5f, 0.4f);
		}
		else if (direction == Vector3Int.right)
		{
			lookerCollider.size = new Vector2(1.5f, 0.4f);
		}
	}

	public void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "NPC")
		{
			dialog = collider.GetComponent<DialogLines>();
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "NPC")
		{
			dialog = null;
		}
	}
}
