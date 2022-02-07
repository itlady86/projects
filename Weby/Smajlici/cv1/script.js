size = 8

stack = [":-)", ":-/", ":-\|"]

createTable()

function createTable() {
    document.write("<table>");
    for (let i = 0; i < size; i++) {
        document.write("<tr>");
        for(let j = 0; j < size; j++) {
            if (j < i)  {
                document.write("<td id='second'>"+(stack[1])+"</td>");
            } 
            if (i < j) {
                document.write("<td id='first'>"+(stack[0])+"</td>");
            }
            if (i === j) {
                document.write("<td id='third'>"+(stack[2])+"</td>");
            }
        }
            document.write("</tr>");
        }
    document.write("</table>");
}


