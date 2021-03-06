# Rename multiple files on phisical file and SQl Server database.

$fileExpression = '101413_CALRWN*.pdf'
$oldPart = '101413'
$newPart = '102529'
$server = ''
$username = ''
$password = ''

get-childItem -path * -filter $fileExpression | rename-item -newname { $_.name -replace $oldPart,$newPart }


sqlcmd -S $server -U $username -P password -Q "
    update DocManagementFiles set clientcode = $(newPart), name = replace(name, $(oldPart), $(newPart)), url = replace(url, $(oldpart), $(newpart)) where name like replace($(fileExpression),'*','%') and clientcode = $(oldPart)
"


remove-variable $fileExpression
remove-varibale $oldPart
remove-variable $newPart
remove-variable $server
remove-variable $username
remove-variable $password