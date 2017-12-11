<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<%--<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>--%>

<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no" />
<meta name="format-detection" content="telephone=no">
<link href="base.css" rel="stylesheet" type="text/css">
<link href="style.css" rel="stylesheet" type="text/css">
<script type="text/javascript" src="jquery-1.8.3.js"></script>
<script type="text/javascript" src="jquery.form.js"></script>
<title>微信拜年征集</title>
</head>
<body>
	<script src="http://res.wx.qq.com/open/js/jweixin-1.0.0.js"></script>
<%--<script type="text/javascript">
	var appId ='wxdfe8c39494a2a0b5';
	var timestamp = 1511782677;
	var nonceStr ='UQJQHugAzoHWx4cy';
	var signature ='82287c625cf0c656cc44338707f66dd2ab201134';
	wx.config({
	    debug: false,
	    appId: appId,
	    timestamp: timestamp,
	    nonceStr: nonceStr,
	    signature: signature,
	    jsApiList: [
	               'checkJsApi',
	               'onMenuShareTimeline',
	               'onMenuShareAppMessage',
	            ]
	});

wx.ready(function () {
	});	
</script>--%>
<p><img src="zhengji_01.jpg"></p>
<p style=" background-image:url(zhengji_02.jpg); background-size:100% auto; color:#fff; text-align:center;">主办单位：湖北省卫生和计划生育委员会<br>　　　　湖北省卫生计生宣传教育中心</p>
<div class="home_zhengji">
	<div class="zhengji_baidi">
    	<form id="tijiao" action="?Action=zhengji" method="post" runat="server"  enctype ="multipart/form-data">
    	<ul>
    	    <li><label>作者姓名</label><input type="text" required name="AuthorName"></li>

            <li><label>联系电话</label><input type="text" required name="AuthorTelephone" id="telephone" pattern="[0-9]*"></li>
            <li><label>所在单位</label><input type="text" required name="AuthorUnit"></li>
             
            <li><asp:FileUpload ID="MyFileUploadVoice" runat="server" /> 
        <asp:Button ID="FileUploadButtonVoice" runat="server" Text="上传音频" 
            onclick="FileUploadButtonVoice_Click" /></li>
           
             <li><asp:FileUpload ID="MyFileUploadVedio" runat="server" /> 
        <asp:Button ID="FileUploadButtonVideo" runat="server" Text="上传视频" 
            onclick="FileUploadButtonVideo_Click" /></li>
            
            <li><label>文字祝福</label><textarea required name="introduction" rows="5" placeholder="50字以内简要描述祝福内容"></textarea></li>
            <li><asp:Button ID="Button1" runat="server" Text="完成上传"  onclick="Button1_Click"/></li>
        </ul>
        </form>
    </div>
</div>
<div class="tancheng" id="loader">
	<p style="width:10%; margin-left:-5%; top:50%;">
    	<img src="ajax_loader.gif">
    </p>
</div>
<div class="tancheng" id="tancheng">
	<div class="mod">
    	<a href="javascript:;" id="chadiao"><img src="chadiao.png"></a>
        <div style="position:absolute; top:-50px;scrollTop:0px;">
            <div class="l-pic-index"></div>
            <div class="r-pic-index"></div>
            <div class="l-bg-index"></div>
            <div class="r-bg-index"></div>
        </div>
    	
    </div>
</div>
<script src="alert.js" type="text/javascript" charset="utf-8"></script>
<script type="text/javascript">
//$("#chadiao").click(function(){
//	$("#tancheng").hide();	
//	$("#yinpzs").html("点击上传");
//	$("#shipzs").html("点击上传");
//	document.getElementById("tijiao").reset();
//});
//$(".tancheng").height($(document).height());
//$("#yinp").change(function(){
//	$("#yinpzs").html($(this).val());
//});
//$("#ship").change(function(){
//	$("#shipzs").html($(this).val());
//});
//$('#tijiao').submit(function() { 
// 	if(!checkMobile($("#telephone").val())){
//		alert("请输入正确的手机号码")
//		return false;
//	}
// 	if($("#yinp").val()=="" || $("#ship").val()==""){
// 		alert("请上传音频或视频")
// 		return false;
// 	}
//	$("#loader").show();
//	$(this).ajaxSubmit(function(data) {
//		var data = eval("(" + data + ")"); 
//		if(data.status==1){
//			$("#tancheng").show();	
//			$(".l-pic-index").animate({'left':'0px','top':'51px'},1300);
//			$(".r-pic-index").animate({'left':'0px','top':'433px'},1450);
//			$(".l-bg-index").animate({'height':'100px','top':'197px'},1500);
//			$(".r-bg-index").animate({'height':'136px','top':'297px'},1500);	
//		}else{
//			alert(data.ermsg);	
//		}
//		$("#loader").hide();
//    }); 
//    return false;
//});
//function checkMobile(obj){  
//    var reg= /^[1][3578]\d{9}$/;  
//	if(!reg.test(obj)){  
//		return false;  
//	}else{
//		return true;	
//	} 
//} 
//function cleanfile(picName)
//{
//	var afile = $("#" + picName);
//	afile.replaceWith(afile.clone()); 
//}
</script></body>
</html>


