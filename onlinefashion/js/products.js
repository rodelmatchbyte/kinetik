'use strict'

var products = [

	{
		url:'staple-superior-5964-270721-1-catalog.jpg',
		onhover:'staple-superior-5964-270721-2-catalog.jpg',
		brand:'Staple Superior', 
		name:'Teddy Boy Chinos', 
		price:69.75,
		category:'Pants',
		catalogImage: 'staple-superior-6066-270721-6-product.jpg',
		brandLogo: 'staple-superior.jpg',
		description: 'Classic, slim fit chinos. The Staple Superior Teddy Boy Chinos have a fixed waistband with belt loops, and a button and zip fly front. The chinos have twin pockets on the front, and welted pockets on the rear. The Staple Superior Teddy Boy Chinos have a blended cotton composition, and provide a low rise, slim-leg fit.'
	},
	
	{
		url:'globe-2217-076021-1-catalog.jpg',
		onhover:'globe-2217-076021-2-catalog.jpg',
		brand:'Globe', 
		name:'Goodstock Jeans', 
		price:69.25,
		category:'Jeans',
		catalogImage: 'globe-2331-076021-6-product.jpg',
		brandLogo: 'globe.jpg',
		description: 'Men`s slim fit jeans. The Globe Goodstock Jeans have a classic design with a button and zip-fly closure, belt loops on the waistband, and a five pocket structure. The jeans have a cotton blend construction with a denim finish, and offer a slim fit. Measurements: Front Rise: 24cm Inside Leg: 78cm Leg Opening: 28cm.'
	},	
	
	{
		url:'ben-sherman-4715-863911-1-catalog.jpg',
		onhover:'ben-sherman-4715-863911-2-catalog.jpg',
		brand:'Ben Sherman', 
		name:'Plain Blazer', 
		price:279.50,
		category:'Suits & Blazers',
		catalogImage: 'ben-sherman-4741-863911-5-product.jpg',
		brandLogo: 'ben-sherman.jpg',
		description: 'Classic, cotton jacket. The Ben Sherman Plain Blazer has a notched collar and lapel, and two button fastenings on the front. The jacket has long sleeves with four buttons, features a chest pocket, and twin flap pockets on the front. The Ben Sherman Plain Blazer is made from 100% premium cotton, and has a striped lining with twin internal chest pockets.'
	},
	
	{
		url:'afends-9311-947021-1-catalog.jpg',
		onhover:'afends-9311-947021-2-catalog.jpg',
		brand:'Afends', 
		name:'Ay Caramba SS Shirt', 
		price:69.75,
		category:'Shirts and Polos',
		catalogImage: 'afends-9371-947021-5-product.jpg',
		brandLogo: 'afends.jpg',
		description: 'Paisley-printed, short-sleeved shirt. Crafted from a 100% durable cotton fabric, the Afends Ay Caramba SS Shirt has a traditional collar and short sleeves. The shirt has a button-down front with shiny black branded buttons, a regular fit, and features a modern paisley print. Length: 80cm.'
	},
	
	{
		url:'g-starraw-7649-678701-1-catalog.jpg',
		onhover:'g-starraw-7649-678701-2-catalog.jpg',
		brand:'G-Star Raw', 
		name:'Correct Line Shirt', 
		price:120.25,
		category:'Shirts & Polos',
		catalogImage: 'g-starraw-7660-678701-2-product.jpg',
		brandLogo: 'g-star.jpg',
		description: 'Long-sleeved shirt with embroidered logo. The G-Star RAW Correct Line Core Shirt LS has a regular shirt collar, and a button-up front. The shirt has long sleeves with mitred cuffs, and features the signature G-Star RAW logo embroidered on the chest. The G-Star RAW Correct Line Core Shirt LS has a blended cotton composition, and has a regular fit.'
	},
	

	
	{
		url:'everloom-6402-147111-1-catalog.jpg',
		onhover:'everloom-6402-147111-2-catalog.jpg',
		brand:'Everloom', 
		name:'Dylanger Shirt', 
		price:34.50,
		category:'T-Shirts & Singlets',
		catalogImage: 'everloom-6407-147111-5-product.jpg',
		brandLogo: 'everloom.jpg',
		description: 'Men`s basic tee. The Everloom Dylanger T-Shirt has a round neckline and a short-sleeved design with rolled cuffs. Made from 100% cotton, the classic tee has a patch pocket on the chest and a slim fit. '
	},
	
	{
		url:'g-starraw-7227-504911-1-catalog.jpg',
		onhover:'g-starraw-7227-504911-2-catalog.jpg',
		brand:'G-Star Raw', 
		name:'Key R Tee SS', 
		price:50.00,
		category:'T-Shirts & Singlets',
		catalogImage: 'g-starraw-7286-504911-5-product.jpg',
		brandLogo: 'g-star.jpg',
		description: 'Grey marle tee. The G-Star RAW Key R Tee SS has a ribbed, rounded neckline and a short-sleeved design. Cut from a soft cotton, the casual tee has a large, flocked G-Star RAW logo on the front, and contrast topstitching. The G-Star RAW Key R Tee SS has a grey marle finish and a slim fit. '
	},
	
	{
		url:'oneill-3138-607021-1-catalog.jpg',
		onhover:'oneill-3138-607021-2-catalog.jpg',
		brand:'O`Neill', 
		name:'History Arch Tee', 
		price:49.50,
		category:'T-Shirts & Singlets',
		catalogImage: 'oneill-3196-607021-5-product.jpg',
		brandLogo: 'oneill.jpg',
		description: 'Printed, casual tee. The O`Neill History Arch Tee has a rounded neckline and a short-sleeved design. Cut from a soft cotton, the men`s tee has a large printed on the front, and a faded black finish. Length: 75cm.'
	}
]

function sku(){
	var chars = ['0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z']

	var sku = ''
	for(var i = 0; i < 11; i++) sku += chars[rand(35)]
	
	return sku;

	
}