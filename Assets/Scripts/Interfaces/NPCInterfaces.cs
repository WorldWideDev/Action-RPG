using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDetectable
{
	void DetectEntry();
	void DetectExit();

	float DetectionDistance();
}