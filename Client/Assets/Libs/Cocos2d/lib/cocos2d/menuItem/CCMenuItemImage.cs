using UnityEngine;
using System.Collections;

namespace Cocos2d{
	public class CCMenuItemImage : CCMenuItemSprite<CCSprite>{
		public CCMenuItemImage(string normalImage, string selectedImage, CCMenuItemDelegate block){
			init (normalImage, selectedImage, null, block);
		}
		public CCMenuItemImage(string normalImage, string selectedImage, string disabledImage=null, CCMenuItemDelegate block=null){
			init (normalImage, selectedImage, disabledImage, block);
		}
		void init(string normalImage, string selectedImage, string disabledImage, CCMenuItemDelegate block){
			CCSprite normalSprite = new CCSprite(normalImage);
			CCSprite selectedSprite = null;
			CCSprite disabledSprite = null;
			
			if( selectedImage != null )
				selectedSprite = new CCSprite(selectedImage);
			if(disabledImage!=null)
				disabledSprite = new CCSprite(disabledImage);
			base.init (normalSprite, selectedSprite, disabledSprite, block);
		}
		
		//
		// Setter of sprite frames
		//
		public void setNormalSpriteFrame(CCSpriteFrame frame)
		{
			this.normalImage = new CCSprite (frame);
		}
		
		public void setSelectedSpriteFrame(CCSpriteFrame frame)
		{
			this.selectedImage = new CCSprite (frame);
		}
		
		public void setDisabledSpriteFrame(CCSpriteFrame frame)
		{
			this.disabledImage = new CCSprite (frame);
		}
	}
}