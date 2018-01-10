using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
 * gr: for some reason, unity cannot resolve this exception from System.IO...
*/
public class InvalidDataException : Exception
{
	public InvalidDataException(string Message="") : base(Message)
	{
	}
}
