import { useEffect, useState } from "react";



export default function Home(): JSX.Element {

  const [products, setProduts] = useState([]);

  useEffect(() => {
    
    fetch('http://localhost:5000/product')
    .then(response => response.json())
    .then(data => {
      setProduts(data)
      console.log(products)
    });

  }, [])


  return (
    <>
      

      <div>
        <h1>Mostrando registros que tem no banco</h1>
        <br></br>
        <br></br>
        <br></br>

        
        
        <ul>
          {products.map(item => (
              <li 
                  key={item.id} 
              >
                  <h2>Produto:</h2> {item.description}
              <h2>BARCODE:</h2> {item.barcode}
              </li>    
          ))}
        </ul>



      </div>
    </>
  );
}
