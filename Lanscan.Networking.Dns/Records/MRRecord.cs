//////////////////////////////////////////////////////////////////////
//
// Lanscan
// Copyright (C) 2013, Richard Cook. All rights reserved.
//
//////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////
//
// Based on Alphons van der Heijden's code presented at
// http://www.codeproject.com/Articles/23673/DNS-NET-Resolver-C
//
// Licensed under Code Project Open License (CPOL) 1.02
// http://www.codeproject.com/info/cpol10.aspx
//
//////////////////////////////////////////////////////////////////////

namespace Lanscan.Networking.Dns.Records
{
    using System;

    public sealed class MRRecord : Record
    {
        private readonly string m_newName;

        public MRRecord(RR rr, RecordReader recordReader)
            : base(rr)
        {
            if (recordReader == null)
            {
                throw new ArgumentNullException("recordReader");
            }

            m_newName = recordReader.ReadDomainName();
        }

        public string NEWNAME
        {
            get { return m_newName; }
        }

        public override string ToString()
        {
            return m_newName;
        }
    }
}
