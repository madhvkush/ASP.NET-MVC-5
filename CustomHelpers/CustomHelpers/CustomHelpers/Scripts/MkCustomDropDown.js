
var top_pos=0;var left_pos=0;
function funOnClickDropdown(objID)
{
    
	var ObjId=objID; 
	
	//alert(ObjId);
	
	var x = $("#"+ObjId).offset();
			
			 top_pos=x.top+30;
			 left_pos=x.left;
			
			
			
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("position", "absolute");
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("left", left_pos);
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("top", top_pos);
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("overflow-y", "auto");
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("width",$("#"+ObjId).width());
			$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).focus();
	
	//document.getElementsByClassName("ui-dropdownchecklist-dropcontainer")[0].offsetTop =top_pos;
//	document.getElementsByClassName("ui-dropdownchecklist-dropcontainer")[0].offsetLeft =left_pos;
	//document.getElementsByClassName("ui-dropdownchecklist-dropcontainer")[0].style.width= obj.style.width;
	$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("display","block");
	$( ".ui-dropdownchecklist-dropcontainer[name="+ObjId+"]" ).css("width",obj.style.width);
	//document.getElementsByClassName("ui-dropdownchecklist-dropcontainer")[0].style.display='block';
}

//on clcik chck
function onClickCheckBoxLine(obj)
{
	var txtID= obj.parentNode.getAttribute("name");
	
	var StringAryText=document.getElementById(txtID).value.split(",");
	var StringAryValue=$("#"+txtID).next().val().split(",");
	
	var valueIndex=StringAryValue.indexOf(obj.childNodes[0].value);
		var TextIndex=StringAryText.indexOf(obj.childNodes[1].innerHTML);
	
	
	if(obj.childNodes[0].getAttribute("Checked")==null)
	{
	obj.childNodes[0].setAttribute("Checked", "Checked");
	 
		
		
		
		if(valueIndex==-1)
		{
			if(StringAryText.join().trim()!="")
			{
			document.getElementById(txtID).value=StringAryText.join()+","+obj.childNodes[1].innerHTML;
			$("#"+txtID).next().val(StringAryValue.join()+","+obj.childNodes[0].value);
			}
			else
			{
			document.getElementById(txtID).value=obj.childNodes[1].innerHTML;
			$("#"+txtID).next().val(obj.childNodes[0].value);
			}
		}
	}
	else
	{ 
		obj.childNodes[0].removeAttribute("Checked");
		
			if(valueIndex!=-1 )
			{
				StringAryText.splice(TextIndex,1);
				StringAryValue.splice(valueIndex,1);
				
				document.getElementById(txtID).value=StringAryText.join();
				$("#"+txtID).next().val(StringAryValue.join());
			}
			
	}
}
//hide on outside click
$(document).mouseup(function (e)
{
    var container = $( ".ui-dropdownchecklist-dropcontainer" );

    if (!container.is(e.target) // if the target of the click isn't the container...
        && container.has(e.target).length === 0) // ... nor a descendant of the container
    {
        container.hide();
    }
});

function fnSetItemList(elelmentId,optionText,optionValue,IsChecked)
{
	var StringAryText=document.getElementById(elelmentId).value.split(","); //value of text box
	var StringAryValue=$("#"+elelmentId).next().val().split(","); //value of hidden
	
	var valueIndex=StringAryValue.indexOf(optionValue);
	var TextIndex=StringAryText.indexOf(optionText);
	if(valueIndex==-1)
	{
		if(IsChecked)
		{
			
			if(StringAryText.join().trim()!="")
			{
				document.getElementById(elelmentId).value=StringAryText.join()+","+optionText;
				$("#"+elelmentId).next().val(StringAryValue.join()+","+optionValue);
			}
			else
			{
				document.getElementById(elelmentId).value=optionText;
				$("#"+elelmentId).next().val(optionValue);
			}
			
			var str='<div class="ui-dropdownchecklist-item" style="white-space: nowrap;" onclick="onClickCheckBoxLine(this)"><input type="checkbox" checked="checked" disabled index="0" value="'+optionValue+'"><span class="ui-dropdownchecklist-text" style="cursor: default; width: 100%;">'+optionText+'</span></div>';
		}
		else
		{
			var str='<div class="ui-dropdownchecklist-item" style="white-space: nowrap;" onclick="onClickCheckBoxLine(this)"><input type="checkbox" disabled index="0" value="'+optionValue+'"><span class="ui-dropdownchecklist-text" style="cursor: default; width: 100%;">'+optionText+'</span></div>';
		}
		
		$( ".ui-dropdownchecklist-dropcontainer[name="+elelmentId+"]" ).append(str);
	}
}

// onclick dropdown anywhere
$(document).ready(function () {
    $(".ui-dropdownchecklist-wrapper").click(
    function () {
        //alert($(this).find("input[type='text']").attr("id")); 
        //get id of textbox and passs it to function
        funOnClickDropdown($(this).find("input[type='text']").attr("id"))

    });
});
		
function fnGetSelectedValue(elelmentId)
{
	return $("#"+elelmentId).next().val();
}

function fnGetClearList(elelmentId)
{
	$("#"+elelmentId).next().val("");
	$("#"+elelmentId).val("");
	$(".ui-dropdownchecklist-dropcontainer[name="+elelmentId+"]").html("");
}		
    

