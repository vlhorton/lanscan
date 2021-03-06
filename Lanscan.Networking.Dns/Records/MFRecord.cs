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

    public sealed class MFRecord : Record
    {
        private readonly string m_madName;

        public MFRecord(RR rr, RecordReader recordReader)
            : base(rr)
        {
            if (recordReader == null)
            {
                throw new ArgumentNullException("recordReader");
            }

            m_madName = recordReader.ReadDomainName();
        }

        public string MADNAME
        {
            get { return m_madName; }
        }

        public override string ToString()
        {
            return m_madName;
        }
    }
}
