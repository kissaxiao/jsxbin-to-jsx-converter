﻿using System;

namespace jsxbin_to_jsx.JsxbinDecoding
{
    public class ExprNode : AbstractNode
    {
        LineInfo lineInfo;
        INode expr;

        public override string Marker
        {
            get { return Convert.ToChar(0x4A).ToString(); }
        }

        public override NodeType NodeType
        {
            get
            {
                return NodeType.ExprNode;
            }
        }

        public override void Decode()
        {
            lineInfo = DecodeLineInfo();
            expr = DecodeNode();
        }

        public override string PrettyPrint()
        {
            string labels = lineInfo.CreateLabelStmt();
            return labels + expr.PrettyPrint();
        }
    }
}