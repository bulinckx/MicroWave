Avaliação C# e Orientação a Objeto
Objetivo
Programar em C# um MICRO-ONDAS DIGITAL.

Requisitos 
Os requisitos foram separados em níveis de dificuldade. Primeiro atenda aos requisitos do nível 1, para então atender aos requisitos do nível 2, e assim por diante. No mínimo os requisitos do nível 3 devem ser entregues ao final da avaliação. Ao entregar, informe qual nível o programa atende. A consulta da Web é permitida durante a avaliação, porém tudo que for implementado, tenha sido copiado da internet ou não, será avaliado.
Os seguintes requisitos são OBRIGATÓRIOS em todos os níveis:
    A. Utilize conceitos de orientação a objetos;
    B. .Net Framework 4.0 ou superior;
    C. Não se preocupar com o visual do formulário, mas sim com a implementação do micro-ondas 
    D. Separar as camadas de interface de usuário e de negócio;
    E. O programa desenvolvido deve funcionar conforme os requisitos de cada nível;

Os seguintes requisitos são DESEJÁVEIS E DIFERENCIAIS em todos os níveis:
    F. Observar os princípios SOLID.
    G. Design patterns.
    H. Boas práticas e qualidade de código visando facilidade de leitura e compreensão.
    I. Implementar as classes de maneira a prevenir o uso incorreto, protegendo devidamente o acesso aos dados e métodos.
    J. Documentar o código quando necessário.
    K. Implementar testes unitários para a camada de negócio.

Nível 1

    1. Deve receber como entrada uma string;
    2. Deve permitir que se parametrize o tempo de cozimento e a potência, onde:
        a. O tempo máximo é 2 minutos e o mínimo é 1 segundo;
        b. A fração mínima do tempo permitida é de 1 segundo;
        c. A potência varia de 1 a 10, assumindo 10 como potência padrão.
    3. Deve permitir que se inicie o aquecimento de acordo com o tempo e potência parametrizados.
        a. Se o tempo não tiver sido parametrizado, lançar uma exceção solicitando a parametrização do tempo antes de iniciar o aquecimento.
        b. Se o tempo estiver fora dos limites de valor, lançar uma exceção solicitando a correta parametrização do tempo.
        c. Se a potência estiver fora dos limites de valor, lançar uma exceção solicitando a correta parametrização da potência.
    4. Deve permitir o início rápido do aquecimento, onde o tempo é parametrizado automaticamente em 30 segundos e a potência em 8.
    5. A cada segundo de aquecimento devem ser adicionados pontos (.) ao final da string fornecida inicialmente, conforme a potência. Ou seja, se a potência for 1, adiciona um ponto. Se a potência for 2, adiciona dois pontos (..), e assim por diante.
    6. Ao final do aquecimento, disponibilizar a string “aquecida”.

Nível 2

    7. O micro-ondas deve fornecer 5 programas de aquecimento com tempo e potência pré-definidos. 
        a. Cada programa deve verificar se é compatível com o tipo de string fornecido:
            i. Para isso, procurar na string por algum texto chave (ex: frango). Se encontrar, permite a utilização do programa. Se não encontrar, lançar uma exceção de alimento incompatível com o programa.
        b. Cada programa deve ter um nome e instruções de uso;
        c. Cada programa deve “aquecer” a string com um caractere diferente, pré-definido (ao invés de ponto);
        d. Deve ser possível consultar os programas existentes, obtendo seus nomes, instruções, tempo e potência. 
        e. Deve ser possível consultar os programas de acordo com o alimento compatível, obtendo seus nomes, instruções, tempo e potência.
        f. Permitir o disparo do aquecimento utilizando um dos programas.

Nível 3

    8. Permitir que a lista de programas originais seja estendida. Ou seja, a aplicação deve permitir que sejam criados programas de aquecimento customizados:
        a. Em cada programa deve-se definir nome, instruções, tempo, potência e caractere de “aquecimento”;
        b. Cada programa deve implementar sua própria verificação de compatibilidade do alimento;
        c. Uma vez que o programa tenha sido criado, ele deve constar juntamente com os programas originais do micro-ondas.
Nível 4

    9. Implementar um evento para notificar a conclusão do aquecimento, que terá como argumento a string aquecida.
    10. Implementar um evento para notificar as mensagens de erro, que terá como argumento a string da mensagem.
        a. Dispara o evento de mensagem nos locais em que são lançadas exceções de negócio;
        b. Se o evento de mensagens tiver sido assinado, não lançar as exceções.
Nível 5

    11. Permitir que a entrada seja uma string ou um arquivo de texto em disco:
        a. Quando for um arquivo, a cada segundo o arquivo deve ser atualizado com os caracteres de aquecimento do programa, conforme feito com a string.
        b. Para saber se é um arquivo, verificar se a string fornecida é um caminho para um arquivo existente.
Nível 6

    12. Permitir que o aquecimento seja pausado ou cancelado a qualquer momento:
        a. Se o aquecimento foi pausado, ele pode ser retomado do ponto em que parou.
        b. Se o aquecimento foi cancelado, ele não pode ser retomado.
