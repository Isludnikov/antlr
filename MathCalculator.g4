grammar MathCalculator;

numericExpression : multiplyingExpression (PLUSMINUSOP multiplyingExpression)*;
multiplyingExpression : powExpression (MULDIVMODOP powExpression)*;
powExpression : unaryMinus (POW unaryMinus)?;

unaryMinus: MINUS? atom;

atom
   : scientific
   | scalarVariable
   | group
   | func
   ;

group : LPAREN numericExpression RPAREN;

scientific : number (E number)?;

func : funcName LPAREN parameters? RPAREN;

parameters : parameter (COMMA parameter)*;
parameter : (paramName LET)? paramValue;

funcName : ID;
paramName : ID;
paramValue : numericExpression;

number : DIGIT+ (POINT DIGIT+)?;

scalarVariable : ID ('.' ID)*;

STRING : '"'  ([\\] ('\u0000'..'\uFFFE') | ~[\\"])* '"'
       | '\'' ([\\] ('\u0000'..'\uFFFE') | ~[\\'])* '\'';

PLUSMINUSOP : PLUS | MINUS;
MULDIVMODOP : MUL | DIV | MOD;

LET : '=';
LPAREN : '(';
RPAREN : ')';
PLUS : '+';
MINUS : '-';
MUL : '*';
DIV : '/';
MOD : '%';
POINT : '.';

E : 'e' | 'E';

POW : '^';

COMMA : ',';

DIGIT : ('0' .. '9');
ID : [a-zA-Z_] [a-zA-Z0-9_]*;
WS : [ \r\n\t] + -> channel (HIDDEN);
