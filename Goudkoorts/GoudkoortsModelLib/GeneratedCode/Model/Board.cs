﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Model
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Board
	{
		public virtual List<List<Vak>> Field
		{
			get;
			set;
		}

		public virtual IEnumerable<Vak> Vak
		{
			get;
			set;
		}

		public virtual IEnumerable<Loods> Loods
		{
			get;
			set;
		}

		public virtual Game Game
		{
			get;
			set;
		}

		public virtual Board Generate()
		{
			throw new System.NotImplementedException();
		}

	}
}

