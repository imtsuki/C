﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace C
{
    public enum OperatorVal
    {
        LBRACKET,
        RBRACKET,
        LPAREN,
        RPAREN,
        PERIOD,
        COMMA,
        QUESTION,
        COLON,
        TILDE,
        SUB,
        RARROW,
        DEC,
        SUBASSIGN,
        ADD,
        INC,
        ADDASSIGN,
        BITAND,
        AND,
        ANDASSIGN,
        MULT,
        MULTASSIGN,
        LT,
        LEQ,
        LSHIFT,
        LSHIFTASSIGN,
        GT,
        GEQ,
        RSHIFT,
        RSHIFTASSIGN,
        ASSIGN,
        EQ,
        BITOR,
        OR,
        ORASSIGN,
        NOT,
        NEQ,
        DIV,
        DIVASSIGN,
        MOD,
        MODASSIGN,
        XOR,
        XORASSIGN,
        SEMICOLON,
        LCURL,
        RCURL
    }
    public class TokenOperator : Token
    {
        public TokenOperator(OperatorVal val)
        {
            this.Val = val;
        }
        public override TokenKind Kind { get; } = TokenKind.OPERATOR;
        public OperatorVal Val { get; }
        public static Dictionary<String, OperatorVal> Operators { get; } = new Dictionary<string, OperatorVal>()
        {
            { "[",    OperatorVal.LBRACKET     },
            { "]",    OperatorVal.RBRACKET     },
            { "(",    OperatorVal.LPAREN       },
            { ")",    OperatorVal.RPAREN       },
            { ".",    OperatorVal.PERIOD       },
            { ",",    OperatorVal.COMMA        },
            { "?",    OperatorVal.QUESTION     },
            { ":",    OperatorVal.COLON        },
            { "~",    OperatorVal.TILDE        },
            { "-",    OperatorVal.SUB          },
            { "->",   OperatorVal.RARROW       },
            { "--",   OperatorVal.DEC          },
            { "-=",   OperatorVal.SUBASSIGN    },
            { "+",    OperatorVal.ADD          },
            { "++",   OperatorVal.INC          },
            { "+=",   OperatorVal.ADDASSIGN    },
            { "&",    OperatorVal.BITAND       },
            { "&&",   OperatorVal.AND          },
            { "&=",   OperatorVal.ANDASSIGN    },
            { "*",    OperatorVal.MULT         },
            { "*=",   OperatorVal.MULTASSIGN   },
            { "<",    OperatorVal.LT           },
            { "<=",   OperatorVal.LEQ          },
            { "<<",   OperatorVal.LSHIFT       },
            { "<<=",  OperatorVal.LSHIFTASSIGN },
            { ">",    OperatorVal.GT           },
            { ">=",   OperatorVal.GEQ          },
            { ">>",   OperatorVal.RSHIFT       },
            { ">>=",  OperatorVal.RSHIFTASSIGN },
            { "=",    OperatorVal.ASSIGN       },
            { "==",   OperatorVal.EQ           },
            { "|",    OperatorVal.BITOR        },
            { "||",   OperatorVal.OR           },
            { "|=",   OperatorVal.ORASSIGN     },
            { "!",    OperatorVal.NOT          },
            { "!=",   OperatorVal.NEQ          },
            { "/",    OperatorVal.DIV          },
            { "/=",   OperatorVal.DIVASSIGN    },
            { "%",    OperatorVal.MOD          },
            { "%=",   OperatorVal.MODASSIGN    },
            { "^",    OperatorVal.XOR          },
            { "^=",   OperatorVal.XORASSIGN    },
            { ";",    OperatorVal.SEMICOLON    },
            { "{",    OperatorVal.LCURL        },
            { "}",    OperatorVal.RCURL        }
        };
        public override String ToString()
        {
            return $"{this.Kind}: {this.Val}: {Operators.First(pair => pair.Value == this.Val).Key}";
        }
    }
}