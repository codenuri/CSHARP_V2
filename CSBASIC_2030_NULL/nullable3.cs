string s = null;
int?   n = null;

if ( s == null ) {}
if ( n == null ) {}

if ( s is null ) {}
if ( n is null ) {}

if ( s.HasValue ) {} // error
if ( n.HasValue ) {} // ok