#region License
/*
* Agent Development and Prototyping Testbed
* https://github.com/ashoulson/ADAPT
* 
* Copyright (C) 2011-2015 Alexander Shoulson - ashoulson@gmail.com
*
* This file is part of ADAPT.
* 
* ADAPT is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published
* by the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
* 
* ADAPT is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Lesser General Public License for more details.
* 
* You should have received a copy of the GNU Lesser General Public License
* along with ADAPT.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using UnityEngine;
using System.Collections;

public class CursorParent : MonoBehaviour
{
    public new Camera camera;
    private float offset = 1.5f;

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.T))
            offset += Time.deltaTime;
        if (Input.GetKey(KeyCode.G))
            offset -= Time.deltaTime;

        Ray cursorRay = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(cursorRay, out hit))
            transform.position = hit.point + offset * Vector3.up;
    }
}

