using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class MouseClickBomb : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 world;
    Vector3Int gridPos;
    Vector3 world2;
    Vector3Int gridPos2;

    public TileBase m_Border;
	public TileBase m_ExplodedFloor;
    public TileBase t_Tile;
    public TileBase y_Tile;
    public TileBase u_Tile;
    public TileBase i_Tile;
    public TileBase o_Tile;
    public TileBase p_Tile;
    public TileBase f_Tile;
    public TileBase g_Tile;
    public TileBase h_Tile;
    public TileBase j_Tile;
    public TileBase k_Kukka;
    public TileBase l_Tile;

    public GameObject putkiMies;
    private Vector3 pmPosition;

    TileBase[] tiilet; // = { t_Tile, y_Tile, u_Tile, i_Tile, o_Tile, p_Tile, f_Tile, g_Tile, h_Tile, j_Tile, k_Tile, l_Tile };

    public GameObject m_Explosion;
	
	private Grid m_Grid;
	public Tilemap m_Foreground;
	public Tilemap m_BackGround;
    public Tilemap m_Esineet;

    public GameObject valitsin;
    private Dropdown dropdown;
    private int tiiliIndex;
    private TileBase valittuTiili;
		void Start ()
	{
		m_Grid = GetComponent<Grid>();
        //m_Foreground = GameObject.Find("Ruoho").GetComponent<Tilemap>();
        //m_BackGround = GameObject.Find("Puut").GetComponent<Tilemap>();
        dropdown = valitsin.GetComponentInChildren<Dropdown>();
        TileBase[] tiili = {t_Tile, y_Tile, u_Tile, i_Tile, o_Tile, p_Tile, f_Tile, g_Tile, h_Tile, j_Tile, k_Kukka, l_Tile };
        tiiliIndex = tiili.GetLength(0);
        Debug.Log("Elementtejä = " + tiiliIndex);
        tiilet = new TileBase[12];
        tiilet = tiili;
        Debug.Log("Tiili 1 = " + tiilet[2]);
    }
	
	// Update is called once per frame
	void Update ()
	{
         mousePosition = Input.mousePosition;
         world =      Camera.main.ScreenToWorldPoint(mousePosition);
         gridPos = m_Grid.WorldToCell(world);

        pmPosition = putkiMies.transform.position;
        //world2 = Camera.main.ScreenToWorldPoint(pmPosition);
        gridPos2 = m_Grid.WorldToCell(pmPosition);

        

        if (Input.GetKeyDown("m"))
        {
            ExplodeCell(gridPos2);
            //m_Foreground.SetTile(gridPos2, valittuTiili);
            Debug.Log("PC world2 " + world2);
            Debug.Log("PC pmPosition " + pmPosition);
            Debug.Log("PC gridPos2 " + gridPos2);
        }

        if (m_Grid && Input.GetMouseButtonDown(0))
		{
            //Debug.Log("Hiirtä klikattu");
            //Vector3 world = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3Int gridPos = m_Grid.WorldToCell(world);
            Debug.Log("Hiirtä klikattu world " + world);
            Debug.Log("Hiirtä klikattu mousePosition " + mousePosition);
            Debug.Log("Hiirtä klikattu gridPos " + gridPos);

            ExplodeCell(gridPos);
			
		}

        if(Input.GetKeyDown("t"))
        {
            m_Foreground.SetTile(gridPos, t_Tile);
        }

        if (Input.GetKeyDown("y"))
        {
            m_Foreground.SetTile(gridPos, y_Tile);
        }

        if (Input.GetKeyDown("u"))
        {
            m_Foreground.SetTile(gridPos, u_Tile);
        }

        if (Input.GetKeyDown("i"))
        {
            m_Foreground.SetTile(gridPos, i_Tile);
        }

        if (Input.GetKeyDown("o"))
        {
            m_Foreground.SetTile(gridPos, o_Tile);
        }

        if (Input.GetKeyDown("p"))
        {
            m_Foreground.SetTile(gridPos, p_Tile);
        }

        if (Input.GetKeyDown("f"))
        {
            m_Foreground.SetTile(gridPos, f_Tile);
        }

        if (Input.GetKeyDown("g"))
        {
            m_Foreground.SetTile(gridPos, g_Tile);
        }

        if (Input.GetKeyDown("h"))
        {
            m_Foreground.SetTile(gridPos, h_Tile);
        }

        if (Input.GetKeyDown("j"))
        {
            m_Foreground.SetTile(gridPos, j_Tile);
        }

        if (Input.GetKeyDown("k"))
        {
            m_Esineet.SetTile(gridPos, k_Kukka);
        }

        if (Input.GetKeyDown("l"))
        {
            m_Foreground.SetTile(gridPos, l_Tile);
        }

        
    }

	private void ExplodeCell(Vector3Int position)
	{
		if (m_Foreground.GetTile(position) == m_Border)
			return;
        Debug.Log("dropdown = " + dropdown);
        Debug.Log("dropdownin arvo = " + dropdown.value);

        valittuTiili = tiilet[dropdown.value];
        if ((mousePosition.x >= 1700) && (mousePosition.y >= 750))
            return;
        {
            m_Foreground.SetTile(position, valittuTiili);
        }

        //foreach (var pos in new BoundsInt(position.x - 1, position.y - 1, position.z, 3, 3, 1).allPositionsWithin)
        //{
        //	if (m_Foreground.GetTile(pos) != null)
        //	{
        //		m_BackGround.SetTile(pos, m_ExplodedFloor);
        //	}
        //}
        //m_Foreground.SetTile(position, null);

        //GameObject.Instantiate(m_Explosion, m_Grid.CellToLocalInterpolated(position + new Vector3(0.5f, 0.5f)), Quaternion.identity);
    }
}
