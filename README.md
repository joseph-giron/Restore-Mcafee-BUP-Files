# Restore-Mcafee-BUP-Files
Utility I wrote to restore McAfee BUP (quarantined) files. 
The files are contain an 7zip header and are XOR'd by a 
magic number. This makes analyzing what McAfee deems 
'dangerous' easier. Just drag and drop. Oh and make sure 
the file is at least larger than 2048 byes (size of header). 
